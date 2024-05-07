using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroInimigo : MonoBehaviour
{
    private Rigidbody2D rB;
    public float speedTiro = 5;
    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rB.velocity = new Vector2(rB.velocity.x, -1 * speedTiro);
    }
}
