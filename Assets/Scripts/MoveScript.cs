using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float moveSpeed;
    public float jumpPower;

    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            transform.position += Vector3.up * jumpPower * Time.deltaTime;
        }
    }
}

