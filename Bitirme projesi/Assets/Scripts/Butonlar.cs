using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Butonlar : MonoBehaviour
{
    public void YeniOyun()
    {
        SceneManager.LoadScene(1);
    }
    public void CikisButonu()
    {
        Application.Quit();
    }
    public void Anamenü()
    {
        SceneManager.LoadScene(0);
    }
    public void GameOver()
    {
        SceneManager.LoadScene(3);
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
