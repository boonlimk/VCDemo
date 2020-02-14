using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float jumpheight = 10.0f;
    private Rigidbody2D rb;
    public float moveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * Time.deltaTime * moveSpeed;
        }
		
        if (Input.GetKey(KeyCode.D))
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
