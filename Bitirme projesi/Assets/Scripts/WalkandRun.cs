using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WalkandRun : MonoBehaviour
{
   
    private Animator animator;
    public float turnSpeed;

    public Transform cam;
    public float lookSensivity;
    public float maxXRot;
    public float minXRot;
    private float curXRot;

    public Text zaman;
    float zamanSayaci = 300;

    bool oyunDevam = true;
    public GameObject gameOverPanel;

    void Start()
    {
        animator = GetComponent<Animator>();
        Time.timeScale = 1;
    }

    void Update()
    {

        Look();

        zamanSayaci -= Time.deltaTime;
        zaman.text = (int)zamanSayaci + "";

        if(zamanSayaci<0)
        {
            oyunDevam = false;
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }

    }
    void Look()
    {
        float x = Input.GetAxis("Mouse X") * lookSensivity;
        float y = Input.GetAxis("Mouse Y") * lookSensivity;
        transform.eulerAngles += Vector3.up * x;

        curXRot += y;
        curXRot = Mathf.Clamp(curXRot, minXRot, maxXRot);

        cam.localEulerAngles = new Vector3(-curXRot, 0.0f, 0.0f);
    }
    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * 2f * Time.deltaTime;
        transform.Translate(movement);

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", true);
            transform.Translate(new Vector3(0, 0, 2f) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKey(KeyCode.R))
        {
            animator.SetBool("isRunning", true);
            transform.Translate(new Vector3(0, 0, 4f) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }
}
