using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

    }

    

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Vector3 tele = Camera.main.ScreenToWorldPoint(mouse);
        if (Input.GetMouseButtonDown(0))
        {
            transform.position = tele;
            transform.position = new Vector3(transform.position.x, transform.position.y, 0.0f); 
        }
    }
}
