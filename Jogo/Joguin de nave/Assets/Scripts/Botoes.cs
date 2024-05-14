using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botoes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IniciarGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Quitar()
    {
        Application.Quit();
    }
    public void Recomecar()
    {
        SceneManager.LoadScene(1);
    }
    public void Pausar()
    {
        Time.timeScale = 0;
    }
    public void Resume()
    {
        Time.timeScale = 1;
    }
}
