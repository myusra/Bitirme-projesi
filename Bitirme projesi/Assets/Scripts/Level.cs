using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void �lklevel()
    {
        SceneManager.LoadScene(2);
    }
    public void �kincilevel()
    {
        SceneManager.LoadScene(3);
    }
    
    public void Anamen�()
    {
        SceneManager.LoadScene(0);
    }
}
