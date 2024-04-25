using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialFloorSpawnerScript : MonoBehaviour
{

    public GameObject floor;

    void Start()
    {
        float initialXPosition = 20f;
        float distanceXPosition = 6.9f;

        for (int i = 0; i < 8; i++)
        {
            Instantiate(floor, new Vector3(initialXPosition - (distanceXPosition * i), -12.50f), transform.rotation);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
