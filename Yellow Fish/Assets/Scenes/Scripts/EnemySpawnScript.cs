using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public float minX, maxX, minY, maxY = 0;
    public GameObject enemy;
    float randX, randY;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    void Start()
    {
    }

    // Update is called once per frame
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
