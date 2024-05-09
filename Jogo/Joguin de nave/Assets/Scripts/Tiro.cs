using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    private Rigidbody2D rB;
    public float speedTiro = 7;
    
    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rB.velocity = new Vector2(rB.velocity.x, 1 * speedTiro);
        
        if(transform.position.y >= 5)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Inimigo")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
