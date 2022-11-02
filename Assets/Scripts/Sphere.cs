using UnityEngine;

public class Sphere : Player                // INHERITANCE
{
    public float speed { get; }= 20;        //ENCAPSULATION
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

        rb.AddForce(Vector3.forward * verticalInput * speed * Time.deltaTime);
        rb.AddForce(Vector3.right * horizontalInput * speed * Time.deltaTime);

        base.Move();
    }

    protected override void Jump()  // POLYMORPHISM
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            base.Jump();
        }
    }
}