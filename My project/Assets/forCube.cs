using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class forCube : MonoBehaviour
{
    public float Speed = 10f;
    public int c;


    public GameObject cylinder;
    public Text x;
    public GameObject cam;
    public GameObject bcam;
    void Start()
    { 
        
    }

    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 15 * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 15 * Speed * Time.deltaTime);
        }
        



        if (c <= 0)
        {
            cam.SetActive(true);
            bcam.SetActive(false);
            this.gameObject.SetActive(false);
            x.text = "game over";
        }

        else x.text = c.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CEN");
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        c--;
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("CEN");
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;

    }
}
