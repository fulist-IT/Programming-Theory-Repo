using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private GameManager gameManager;

    private Vector3 offset { get; } = new Vector3(0f, 0.717f, -0.6f);   //ENCAPSULATION

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void LateUpdate()
    {
        Visual();   // ABSTRACTION
    }

    private void Visual()
    {
        transform.position = gameManager.gameObjectsShapes[gameManager.index].transform.position + offset; 
    }
}
