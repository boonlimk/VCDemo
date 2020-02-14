using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float jumpheight;
    private Rigidbody2D rb;
    public float moveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.right * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position -= Vector3.left * Time.deltaTime * moveSpeed;
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(0, 10 * jumpheight * Time.deltaTime, 0);
        }
    }
}
