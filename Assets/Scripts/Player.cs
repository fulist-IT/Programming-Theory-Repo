using UnityEngine;

public class Player : MonoBehaviour
{
    protected virtual void Move()
    {
        Debug.Log( gameObject.name + " in movement");
        //generic movement
    }

    protected virtual void Jump()
    {
        Debug.Log("Jump");
        //different kinds of jump
    }
}
