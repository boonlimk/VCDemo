using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneFiringMissile : MonoBehaviour
{
    public float timer;
    private float countdownTimer;
    public GameObject missile;

    private void Start()
    {
        countdownTimer = timer;
    }

    private void Update()
    {
        countdownTimer -= Time.deltaTime;
        if (countdownTimer <= 0f)
        {
            Instantiate(missile, transform.position, Quaternion.identity);
            countdownTimer = timer;
        }
    }

}
