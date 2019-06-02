﻿using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public float minX, maxX, minY, maxY = 0;
    public Transform enemy;
    public float spawnRate = 2f;

    private Vector2 whereToSpawn;
    private float randX, randY;
    private float nextSpawn = 0.0f;

    void Update()
    {
        if (Time.time > nextSpawn)
       {
            if (minX == 0f && maxX == 0f)
            {
                randX = transform.position.x;
            }
            else
            {
                randX = Random.Range(minX, maxX);
            }
            if (minY == 0f && maxY == 0f)
            {
                randY = transform.position.y;
            }
            else
            {
                randY = Random.Range(minY, maxY);
            }        
            nextSpawn = Time.time + spawnRate;
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
       } 
    }
}
