using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InimigoMoves : MonoBehaviour
{    
    private Rigidbody2D inimigoRb;
    public float inimigoSpeed = 2;
    private GameManager gM;
    // Start is called before the first frame update
    void Start()
    {
        inimigoRb = GetComponent<Rigidbody2D>();
        gM = GameObject.Find("GameManager").GetComponent<GameManager>(); 
    }

    // Update is called once per frame
    void Update()
    {
        inimigoRb.velocity = new Vector2(inimigoRb.velocity.x,1 * -inimigoSpeed);
        if(transform.position.y <= -5.68f)
        {
            gM.pontuacao += 1;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Tiro")
       { 
            gM.pontuacao += 1;
            Destroy(gameObject,0.25f);
            Destroy(other.gameObject);
       }
    }
}
