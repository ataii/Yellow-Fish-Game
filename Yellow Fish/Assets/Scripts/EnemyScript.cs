using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public MoveScript move;
    public GameObject target;
    public Transform particle;
    public HealthScript health;
    public DamageRate damageRate;
    public UpdateRotationScript rotationScript;

    public int damage;
    public int hp;
    public float minSpeed, maxSpeed;

    void Start()
    {
        health.hp = hp;
        damageRate.damage = damage;
        rotationScript.target = target;
        move.speed = Random.Range(minSpeed, maxSpeed);
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        DamageRate damageRate = otherCollider.transform.gameObject.GetComponent<DamageRate>();
        if (damageRate != null && otherCollider.gameObject.tag.Equals("Enemy") == false)
        {
            health.Damage(damageRate.damage);
            if (health.IsDead())
            {
                ScoreCounterScript.scoreValue += 10;
                Instantiate(particle, transform.position, Quaternion.identity);
                Destroy(transform.gameObject);
            }
        }
    }
}
