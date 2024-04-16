using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    private float heightOffset = 4;

    // Start is called before the first frame update
    void Start()
    {
        this.spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        } else
        {
            this.spawn();
            timer = 0;
        }

        
    }

    private void spawn()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        
        Instantiate(pipe, new Vector3(transform.position.x + 5, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }
}
