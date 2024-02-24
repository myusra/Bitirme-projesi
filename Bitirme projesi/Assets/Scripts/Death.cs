using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject gameOverPanel;
    
    void Start()
    {
        Time.timeScale = 1;
        
    }

    
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag=="Death")
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(2);
    }

    public void Restart2()
    {
        SceneManager.LoadScene(3);
    }
}
