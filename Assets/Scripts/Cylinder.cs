using UnityEngine;

public class Cylinder : Player               // INHERITANCE
{
    private float speed { get; } = 30;       //ENCAPSULATION
    private float jumpForce { get; } = 5;    //ENCAPSULATION

    private Rigidbody rb;

    private float verticalInput;
    bool different;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move(); // ABSTRACTION

        Jump(); // ABSTRACTION
    }

    protected override void Move()  // POLYMORPHISM
    {
        verticalInput = Input.GetAxis("Vertical");
        rb.AddForce(Vector3.forward * verticalInput * speed * Time.deltaTime);

        base.Move();
    }

    protected override void Jump()  // POLYMORPHISM
    {
        if (Input.GetKeyDown(KeyCode.B) && different)
        {
            rb.AddForce(Vector3.right * jumpForce, ForceMode.Impulse);
            different = false;

            base.Jump();
        }
        else if (Input.GetKeyDown(KeyCode.B) && !different)
        {
            rb.AddForce(Vector3.right * -jumpForce, ForceMode.Impulse);
            different = true;

            base.Jump();
        }
        
    }
}
