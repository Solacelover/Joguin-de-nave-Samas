using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoCMoves : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
public float speed;
public float xSpeed;
private float fixSpeed;
private GameManager gM;
private float pInicialX;
public float limiteX;
// Start is called before the first frame update
void Start()
{
    rb = GetComponent<Rigidbody2D>();
    gM = GameObject.Find("GameManager").GetComponent<GameManager>();
    pInicialX = transform.position.x;
    xSpeed = Random.Range(0.5f,1);
    fixSpeed = xSpeed;
}

// Update is called once per frame
void Update()
{
    if (gM.gameOver == false && gM.pause == false)
    {
        rb.velocity = new Vector2(rb.velocity.x, 1 * -speed);
    }
    else if (gM.gameOver == true || gM.pause == true)
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
    }

    if (transform.position.y <= -0.6)
    {
        gM.pontuacao += 1;
        Destroy(gameObject);
    }

    rb.velocity = new Vector2(fixSpeed, rb.velocity.y);
    DeslocarHorizontal();
}

private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.gameObject.tag == "Progetil")
    {
        gM.pontuacao += 1;
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}

private void DeslocarHorizontal()
{      
    if (transform.position.x >= pInicialX + limiteX)
    {
        fixSpeed = -xSpeed;
    }
    else if (transform.position.x <= pInicialX - limiteX)
    {
        fixSpeed = xSpeed;
    }        

    if (gM.gameOver == true || gM.pause == true)
    {
        fixSpeed = 0;
    }
}
}
