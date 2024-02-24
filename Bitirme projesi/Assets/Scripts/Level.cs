using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void Ýlklevel()
    {
        SceneManager.LoadScene(2);
    }
    public void Ýkincilevel()
    {
        SceneManager.LoadScene(3);
    }
    
    public void Anamenü()
    {
        SceneManager.LoadScene(0);
    }
}
