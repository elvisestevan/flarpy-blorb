using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawnScript : MonoBehaviour
{
    public GameObject floor;
    public float spawnRate = 2;
    private float timer = 0;
    private LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        this.spawn();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!logic.isGameOver)
        {
            if (timer < spawnRate)
            {
                timer = timer + Time.deltaTime;
            }
            else
            {
                this.spawn();
                timer = 0;
            }
        }
    }

    private void spawn()
    {
        Instantiate(floor, new Vector3(26.75f, -12.50f), transform.rotation);

    }
}
