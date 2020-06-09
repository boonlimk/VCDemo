using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public GameObject [] Enemy;
    public float spawnTime = 3f;
    private Vector3 spawnlocation;
 
    // Start is called before the first frame update
    void Start()
    {
            InvokeRepeating("Spawn", spawnTime,spawnTime);
    }

    // Update is called once per frame
    void Spawn()
    {
      
        spawnlocation.x = Random.Range(5, 9);
        spawnlocation.y = -1.5f;
        spawnlocation.z = 0f;

        Instantiate(Enemy[UnityEngine.Random.Range(0,Enemy.Length-1)], spawnlocation, Quaternion.identity);
    }
}
