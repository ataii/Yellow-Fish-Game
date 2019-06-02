using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public float minSpeed, maxSpeed;
    public float spawnRate = 2f;
    public Transform enemy;

    private float minX, maxX, minY, maxY = 0;
    private Vector2 whereToSpawn;
    private float randX, randY;
    private float nextSpawn = 0.0f;
    private MoveScript moveScript;

    private void Start()
    { 
        moveScript = enemy.gameObject.GetComponent<MoveScript>();
        this.GetBoxSize();
    }

    void Update()
    {
        this.RandomSpawn();
    }

    void GetBoxSize()
    {
        minX = transform.position.x - transform.localScale.x / 2;
        maxX = transform.position.x + transform.localScale.x / 2;
        minY = transform.position.y - transform.localScale.y / 2;
        maxY = transform.position.y + transform.localScale.y / 2;
    }

    void RandomSpawn()
    {
        if (Time.time > nextSpawn)
        {
            randX = minX.Equals(0f) && maxX.Equals(0f) ? transform.position.x : Random.Range(minX, maxX);
            randY = minY.Equals(0f) && maxY.Equals(0f) ? transform.position.y : Random.Range(minY, maxY);
            nextSpawn = Time.time + spawnRate;
            whereToSpawn = new Vector2(randX, randY);
            moveScript.speed = Random.Range(minSpeed, maxSpeed);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
}