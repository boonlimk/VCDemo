using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    float amount;
    public float height = 1.0f;
    public float moveSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
            amount += Time.deltaTime;
        }
        
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Up") * moveSpeed);
        }

            
    }
}
