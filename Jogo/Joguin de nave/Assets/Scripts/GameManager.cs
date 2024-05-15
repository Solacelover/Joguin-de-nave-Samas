using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public bool pause;
    public GameObject inimigo;
    public GameObject inimigoB;
    public GameObject inimigoC;
    private float tempoGerar;
    private float tempoGerarB;
    private float tempoGerarC;
    public float delay;
    public float delayB;
    public float delayC;

    public AudioSource gmAudio;
    public AudioClip somTiro;

    public int pontuacao;
    public TextMeshProUGUI pontuacatxt;
    public GameObject telaPause;
    public GameObject botaoDePause;
    public GameObject telaDeGameOver;
    // Start is called before the first frame update
    void Start()
    {
        gmAudio = GetComponent<AudioSource>();
        gmAudio.mute = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver != true && tempoGerar <= Time.time && pause == false)
        {
            Instantiate(inimigo, new Vector3(Random.Range(-2.29f,2.3f),6,0), Quaternion.identity);
            tempoGerar = Time.time + delay;
        }
        if (gameOver != true && tempoGerarB <= Time.time && pause == false)
        {
            Instantiate(inimigoB, new Vector3(Random.Range(-2.29f,2.3f),6,0), Quaternion.identity);
            tempoGerarB = Time.time + delayB;
        }
        if (gameOver != true && tempoGerarC <= Time.time && pause == false)
        {
            Instantiate(inimigoC, new Vector3(Random.Range(-2.29f,2.3f),6,0), Quaternion.identity);
            tempoGerarC = Time.time + delayC;
        }
        if(gameOver == true)
        {
            Time.timeScale = 0;
            botaoDePause.SetActive(false);
            telaDeGameOver.SetActive(true);
        }
    }
    public void Recomecar()
    {
        SceneManager.LoadScene(1);
    }
    public void Pausar()
    {
        botaoDePause.SetActive(false);
        telaPause.SetActive(true);
        pause = true;
        Time.timeScale = 0;
    }
    public void Resume()
    {
        botaoDePause.SetActive(true);
        telaPause.SetActive(false);
        pause = false;
        Time.timeScale = 1;
    }
    public void MutarEDesmutar()
    {
        gmAudio.mute = !gmAudio.mute;
    }
}
