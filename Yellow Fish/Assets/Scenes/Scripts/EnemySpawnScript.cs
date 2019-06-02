using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public float minX, maxX, minY, maxY = 0;
    public static GameObject enemy;
    public float spawnRate = 2f;

    private Vector2 whereToSpawn;
    private float randX, randY;
    private float nextSpawn = 0.0f;
    MoveScript moveScript;

    void Start()
    {
    }

    void Update()
    {
        moveScript = enemy.GetComponent<MoveScript>();
        enemy.AddComponent<MoveScript>();
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
            moveScript.speed = Random.Range(1f, 10f);
            moveScript.Move();
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        } 
    }
}