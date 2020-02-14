using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Transform selfTr;
    public float moveSpeed = 0.1f;
    public float jumpHeight = 5f;
    bool isJumping;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) // left arrow key
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow)) // right arrow key
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow) && !isJumping) // up arrow key
        {
            isJumping = true;
            transform.Translate(Vector3.up * moveSpeed * jumpHeight * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false;
    }
}
