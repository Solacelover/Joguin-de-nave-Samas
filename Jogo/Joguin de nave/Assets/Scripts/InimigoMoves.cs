using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoMoves : MonoBehaviour
{
    private Rigidbody2D inimigoRb;
    public float inimigoSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        inimigoRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inimigoRb.velocity = new Vector2(inimigoRb.velocity.x,1 * -inimigoSpeed);
        if(transform.position.y <= -5.68f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Tiro")
       { 
            Destroy(gameObject);
            Destroy(other.gameObject);
       }
    }
    
       
    
}
