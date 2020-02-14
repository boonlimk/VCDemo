using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    float amount;
    public float height = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//! BL Edit here
        transform.position = Vector3.down * (Mathf.Sin(amount) * height);
        amount += Time.deltaTime;
    }
}
