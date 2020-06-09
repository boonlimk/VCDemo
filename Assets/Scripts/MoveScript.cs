using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float jumpHeight = 10.0f;
    private Rigidbody2D rb;
    public float moveSpeed = 5.0f;
    private bool canDoubleJump = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
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
            canDoubleJump = true;
            if (canDoubleJump && Input.GetButtonDown("Jump"))
            {
                transform.position += Vector3.up * Time.deltaTime * jumpHeight;
                canDoubleJump = false;
            }
        }
    }
}
