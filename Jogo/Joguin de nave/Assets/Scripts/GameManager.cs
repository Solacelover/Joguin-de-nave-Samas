using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public GameObject inimigo;
    private float tempoGerar;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver != true && tempoGerar <= Time.time)
        {
            Instantiate(inimigo, new Vector3(Random.Range(-2.29f,2.3f),6,0), Quaternion.identity);
            tempoGerar = Time.time + delay;
        }
    }
}
