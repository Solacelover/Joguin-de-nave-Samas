using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoCMoves : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D inimigoRb;
    public float inimigoSpeed = 2.5f;
    public float inimigoSpeedX = 1.25f;
    private int vida = 2;
    void Start()
    {
        inimigoRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inimigoRb.velocity = new Vector2(inimigoSpeedX,1 * -inimigoSpeed);
        if(transform.position.y <= -5.68f)
        {
            Destroy(gameObject);
        }
        if(vida <= 0)
        {
          Destroy(gameObject);  
        }
    }
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Tiro")
       { 
            Destroy(other.gameObject);

       }
       if (other.gameObject.tag == "Parede")
       {
            inimigoSpeedX *= -1;
       }
    }
}
