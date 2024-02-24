using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bitiş : MonoBehaviour
{
    public GameObject bitisPanel;
    void Start()
    {
        Time.timeScale = 1;

    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bitiş")
        {
            Time.timeScale = 0;
            bitisPanel.SetActive(true);
        }

    }
    public void CikisButonu()
    {
        Application.Quit();
    }
    public void Anamenü()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    
    public void İkiSahne()
    {
        SceneManager.LoadScene(3);
    }
    void Update()
    {
        
    }
}
