using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "coin")
        {
            audioSource.Play();
        }
        if (collision.collider.tag == "Death")
        {
            audioSource.Play();
        }
        if (collision.collider.tag == "Bitiþ")
        {
            audioSource.Play();
        }
    }
    void Update()
    {
        
    }
}
