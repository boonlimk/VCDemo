using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingMissileScript : MonoBehaviour
{
    public float speed = 7.0f;
    public float rotationSpeed = 10.0f;
    
    public Transform targetPlayer;

    private Rigidbody2D rb;

    private void Awake()
    {
        targetPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 dir = (Vector2)targetPlayer.position - rb.position;
        dir.Normalize();

        float rotationAmount = Vector3.Cross(dir, transform.up).z;

        rb.angularVelocity = -rotationAmount * rotationSpeed;
        rb.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player") || col.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }

    }
}
