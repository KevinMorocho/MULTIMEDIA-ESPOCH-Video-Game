using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMove : MonoBehaviour
{
    public Text score;
    public Rigidbody rb;
    public float forwardForce = 2000;
    public float sideForce = 2000;
    void Start()
    {
        
    }

    void Update()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);
        if (Input.GetKey("d")|| Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sideForce*Time.deltaTime,0,0);
        }
        
        if (Input.GetKey("a")|| Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sideForce*Time.deltaTime,0,0);
        }

        score.text =transform.position.z.ToString("0");
        
    }
}
