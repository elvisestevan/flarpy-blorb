using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    public float moveSpeed = 5;
    public float deadZone = -30;
    public bool loopSpawn = false;
    public float initialXPosition = 48;
    private LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!logic.isGameOver)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

            if (transform.position.x < deadZone)
            {
                if (loopSpawn)
                {
                    transform.position = new Vector2(initialXPosition, transform.position.y);
                } else
                {
                    Destroy(gameObject);
                }                
            }
        }
        
    }
}
