using UnityEngine;

public class BackgroundScrolling : MonoBehaviour
{

    private MeshRenderer meshRenderer;
    public float scrollingSpeed = 0.5f;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        this.meshRenderer = GetComponent<MeshRenderer>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!logic.isGameOver)
        {
            meshRenderer.material.mainTextureOffset += new Vector2(scrollingSpeed * Time.deltaTime, 0);
        }
        
    }
}
