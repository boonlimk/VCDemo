<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneScript : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;

    public Transform moveSpot;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;


    void Start()
    {
        waitTime = startWaitTime;

        moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpot.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, moveSpot.position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneScript : MonoBehaviour
{
    public float ChaseSpeed=0.2f;
    public bool IsMoveRight=true;
    public float TimeTicker=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsMoveRight==true)
        {
            transform.Translate(Vector2.right * ChaseSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * ChaseSpeed * Time.deltaTime);
        }
        TimeTicker += Time.deltaTime;
        if(TimeTicker>1)
        {
            IsMoveRight = !IsMoveRight;
            TimeTicker = 0;

        }
    }


    
}
>>>>>>> b987a6a06c3868b0a160e28838a0bc3d54d993de
