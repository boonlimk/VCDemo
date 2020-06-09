using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeScript : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Color oriColor;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        oriColor = spriteRenderer.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            spriteRenderer.color = Color.blue;
        }

        if (Input.GetKeyUp(KeyCode.B))
        {
            spriteRenderer.color = oriColor;
        }
    }
}
