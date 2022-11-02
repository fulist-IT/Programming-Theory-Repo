using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Player
{
    private float speed = 40;
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

        rb.AddTorque(Vector3.right * verticalInput * speed * Time.deltaTime);
        rb.AddTorque(Vector3.forward * horizontalInput * -speed * Time.deltaTime);

        base.Move();
    }

    protected override void Jump()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            rb.AddForce(Vector3.forward * jumpForce, ForceMode.Impulse);
            base.Jump();
        }
    }
}
