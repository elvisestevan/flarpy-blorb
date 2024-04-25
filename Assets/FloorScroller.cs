using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class FloorScroller : MonoBehaviour
{

    public float scrollSpeed;
    private TilemapRenderer tilemapRenderer;

    // Start is called before the first frame update
    void Start()
    {
        tilemapRenderer = GetComponent<TilemapRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        tilemapRenderer.material.mainTextureOffset = new Vector2(Time.realtimeSinceStartup * scrollSpeed, transform.position.y);
    }
}
