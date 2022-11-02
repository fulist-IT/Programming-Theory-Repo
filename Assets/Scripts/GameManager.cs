using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //private List<string> nameShapes = new List<string>();
    private List<GameObject> gameObjectsShapes = new List<GameObject>();

    private int index;

    private GameObject sphere;
    private GameObject cube;
    private GameObject cylinder;

    private void Awake()
    {
        //nameShapes.Add("Sphere");
        //nameShapes.Add("Cube");
        //nameShapes.Add("Cylinder");

        listOfShapes();
    }

    private void Start()
    {
        FirstShapeActive();
    }

    private void Update()
    {
        ShapeSwap();
    }

    private List<GameObject> listOfShapes()
    {
        sphere = GameObject.Find("Sphere");
        cube = GameObject.Find("Cube");
        cylinder = GameObject.Find("Cylinder");

        gameObjectsShapes.Add(sphere);
        gameObjectsShapes.Add(cube);
        gameObjectsShapes.Add(cylinder);

        return gameObjectsShapes;
    }


    private void FirstShapeActive()
    {
        for (int i = 0; i < gameObjectsShapes.Count; i++)
        {
            gameObjectsShapes[i].SetActive(false);
        }

        index=Random.Range(0, gameObjectsShapes.Count);
        gameObjectsShapes[index].SetActive(true);
    }


    private void ShapeSwap()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObjectsShapes[index].SetActive(false);
            index++;

            if (index < gameObjectsShapes.Count)
            {
                gameObjectsShapes[index].SetActive(true);
            }
            else
            {
                index = 0;
                gameObjectsShapes[index].SetActive(true);
            }

        }
    }

}