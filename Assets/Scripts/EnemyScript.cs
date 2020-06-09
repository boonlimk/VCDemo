using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float ChaseSpeed = 0.2f;
    public bool IsMoveRight = true;
    public float TimeTicker = 0;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsMoveRight == true)
        {
            transform.Translate(Vector2.right * ChaseSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * ChaseSpeed * Time.deltaTime);
        }
        TimeTicker += Time.deltaTime;
        if (TimeTicker > 1)
        {
            IsMoveRight = !IsMoveRight;
            TimeTicker = 0;

        }
    }
}