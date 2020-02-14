using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float jumpheight;
    public float moveSpeed = 5.0f;
    
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.position += Vector3.right * Time.deltaTime * moveSpeed;
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        }
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            transform.position += Vector3.up * Time.deltaTime * jumpHeight;
        }
    }
}
