using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoBMoves : MonoBehaviour
{
    private Rigidbody inimigoBrb;
    public float inimigoBspeed;
    // Start is called before the first frame update
    void Start()
    {
        inimigoBrb = GetComponent<Rigidbody>();
        inimigoBspeed = Random.Range(2,5);
    }

    // Update is called once per frame
    void Update()
    {
        inimigoBrb.velocity = new Vector2(inimigoBrb.velocity.x, 1 * -inimigoBspeed);
        if (transform.position.y <= -5.68f)
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
