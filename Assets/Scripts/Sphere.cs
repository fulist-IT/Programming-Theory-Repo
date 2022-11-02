using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Sphere : Player
{
    private float speed = 20;
    private float jumpForce = 5;

    private Rigidbody rb;

    private float verticalInput;
    private float horizontalInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();

        Jump();
    }

    protected override void Move()
    {   
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        rb.AddForce(Vector3.forward * verticalInput * speed * Time.deltaTime);
        rb.AddForce(Vector3.right * horizontalInput * speed * Time.deltaTime);

        base.Move();
    }

    protected override void Jump()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            base.Jump();
        }
        
    }
}