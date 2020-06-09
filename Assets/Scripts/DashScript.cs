using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashScript : MonoBehaviour
{
    bool hasDash = false;
    public float dashDelay = 1.0f;
    float dashTimer = 0.0f;
    public float dashSpeed = 20.0f;
    private float dashLeft = 0;
   
    public const float maxDashTime = 0.1f;
    private float currentDashTime = maxDashTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetAxisRaw("Horizontal") > 0 || Input.GetAxisRaw("Horizontal") < 0)
            {
                if (hasDash == false)
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        dashLeft = 1;
                    }
                    if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        dashLeft = 2;
                    }
                    currentDashTime = 0;
                    hasDash = true;
                }
            }
        }

        if(currentDashTime < maxDashTime)
        {
            if (dashLeft == 1)
            {
                transform.position += Vector3.right * Time.deltaTime * dashSpeed;
            }
            if (dashLeft == 2)
            {
                transform.position += Vector3.left * Time.deltaTime * dashSpeed;
            }
            currentDashTime += Time.deltaTime;
        }

        if (hasDash == true)
        {
            if (dashTimer >= dashDelay)
            {
                hasDash = false;
                dashTimer = 0.0f;
            }
            else
            {
                dashTimer += Time.deltaTime;
            }
        }
    }
}
