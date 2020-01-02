using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MoveScript : MonoBehaviour
{
    float value;
    Vector2 movePos;

    [Range(1.0f,30.0f)]
    public float speed = 1.0f;

    [Range(1.0f, 10.0f)]
    public float ringSize = 1.0f;

    public bool VerticalMove = true;
    public bool HorizontalMove = false;
    public bool clockwiseMove = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (clockwiseMove)
        {
            value -= Time.deltaTime;
        }
        else
        {
            value += Time.deltaTime;
        }

        if(VerticalMove)
        {
            movePos.y = Mathf.Sin(value * speed);
        }
        else
        {
            movePos.y = 0.0f;
        }

        if (HorizontalMove)
        {
            movePos.x = Mathf.Cos(value * speed);
        }
        else
        {
            movePos.x = 0.0f;
        }

        transform.position = new Vector3(movePos.x,movePos.y, 0.0f) * ringSize;
    }
}
