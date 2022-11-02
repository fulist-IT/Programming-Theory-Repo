using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Player
{
    private float speed = 30;
    private float jumpForce = 5;

    private Rigidbody rb;

    private float verticalInput;
    bool different;

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
        rb.AddForce(Vector3.forward * verticalInput * speed * Time.deltaTime);

        base.Move();
    }

    protected override void Jump()
    {
        if (Input.GetKeyDown(KeyCode.B) && different)
        {
            rb.AddForce(Vector3.right * jumpForce, ForceMode.Impulse);
            different = false;

            base.Jump();
        }
        if (Input.GetKeyDown(KeyCode.B) && !different)
        {
            rb.AddForce(Vector3.right * -jumpForce, ForceMode.Impulse);
            different = true;

            base.Jump();
        }
        
    }
}
