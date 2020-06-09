using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootBounce : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float DestroyDelay = 5.0f;
    public Vector3 moveVector = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Initialize(Vector3 dir, float speed, float delay)
    {
        moveVector = dir;
        moveSpeed = speed;
        DestroyDelay = delay;
        Destroy(this.gameObject, DestroyDelay);
        //
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveVector * moveSpeed * Time.deltaTime);
    }
}
