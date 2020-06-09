using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletshoot : MonoBehaviour
{
    public GameObject bullet;
    bool hasShot = false;
    public float shootDelay = 0.5f;
    float shootTimer = 0.0f;

    public float bulletSpeed = 5.0f;
    public float DestoryDelay = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasShot == false)
        {
            
            shootBounce bulletMove = Instantiate(bullet, transform.position, Quaternion.identity).GetComponent<shootBounce>();
            if (bulletMove != null)
            {
                bulletMove.Initialize(Vector3.up, bulletSpeed, DestoryDelay);
            }
            hasShot = true;
        }
    
        if (hasShot == true)
        {
            if (shootTimer >= shootDelay)
            {
                hasShot = false;
                shootTimer = 0.0f;
            }
            else
            {
                shootTimer += Time.deltaTime;
            }
        }
    }
}
