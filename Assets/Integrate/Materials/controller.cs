using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Player_Move_UI.up)
        {
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S) || Player_Move_UI.down)
        {
            transform.position -= transform.forward * movementSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A) || Player_Move_UI.left)
        {
            transform.position -= transform.right * movementSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) || Player_Move_UI.right)
        {
            transform.position += transform.right * movementSpeed * Time.deltaTime;
        }
    }
}