using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public float speed = 5;
    private GameManager gM;
    public GameObject tiro;
    private float tempoGerar;
    public float delay =  0.75f;
    public GameObject posicaoTiro;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        gM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Mover
        playerRb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical")) * speed;

        LimiteTela();

        if (gM.gameOver != true && tempoGerar <= Time.time && Input.GetButtonDown("Jump"))
        {
            Instantiate(tiro, new Vector3(posicaoTiro.transform.position.x, posicaoTiro.transform.position.y, 0), Quaternion.identity);
            tempoGerar = Time.time + delay;
        }
    }

    void LimiteTela()
    {
        if(transform.position.x <= -2.291)
        {
            transform.position = new Vector3(-2.291f,transform.position.y, 0);
        }else if(transform.position.x >= 2.311)
        {
            transform.position = new Vector3(2.311f,transform.position.y, 0);
        }
        if(transform.position.y <= -4.704)
        {
            transform.position = new Vector3(transform.position.x,-4.707f,0);
        }else if (transform.position.y >= 4.413)
        {
            transform.position = new Vector3(transform.position.x,4.413f, 0); 
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Inimigo")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            gM.gameOver = true;
        }
    }
}
