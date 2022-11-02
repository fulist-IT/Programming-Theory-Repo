using UnityEngine;

public class Cube : Player                  // INHERITANCE
{
    private float speed { get; } = 40;      //ENCAPSULATION
    private float jumpForce { get; } = 5;   //ENCAPSULATION

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

    protected override void Move()  // POLYMORPHISM
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        rb.AddTorque(Vector3.right * verticalInput * speed * Time.deltaTime);
        rb.AddTorque(Vector3.forward * horizontalInput * -speed * Time.deltaTime);

        base.Move();
    }

    protected override void Jump()  // POLYMORPHISM
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            rb.AddForce(Vector3.forward * jumpForce, ForceMode.Impulse);
            base.Jump();
        }
    }
}
