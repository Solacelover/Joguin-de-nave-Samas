using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoBMoves : MonoBehaviour
{
    
    
    private Rigidbody2D inimigoBrb;
    public float inimigoBspeed;
    public GameObject TiroInimigo;
    // Start is called before the first frame update
    public float delay;

    public GameObject posicaoTiro;

    private float tempoGerar;

    private GameManager gM;

    void Start()
    {
        gM = GameObject.Find("GameManager").GetComponent<GameManager>();
        inimigoBrb = GetComponent<Rigidbody2D>();
        inimigoBspeed = Random.Range(2,5);
    }

    // Update is called once per frame
    void Update()
    {
        inimigoBrb.velocity = new Vector2(inimigoBrb.velocity.x, 1 * -inimigoBspeed);
        if (transform.position.y <= -5.68f)
        {
            gM.pontuacao += 1;
            Destroy(gameObject);
        }
         if (gM.gameOver != true && tempoGerar <= Time.time)
        {
            Instantiate(TiroInimigo, new Vector3(posicaoTiro.transform.position.x, posicaoTiro.transform.position.y, 0), Quaternion.identity);
            tempoGerar = Time.time + delay;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tiro")
        {
            gM.pontuacao += 1;
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
