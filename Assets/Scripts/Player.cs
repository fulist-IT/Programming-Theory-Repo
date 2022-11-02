using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    protected virtual void Move()
    {
        Debug.Log( gameObject.name + "Movement");
        //generic movement
    }

    protected virtual void Jump()
    {
        Debug.Log("Jump");
        //different kinds of jump
    }
}
