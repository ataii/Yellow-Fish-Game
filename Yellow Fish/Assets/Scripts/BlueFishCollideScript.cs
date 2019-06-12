using UnityEngine;

public class BlueFishCollideScript : MonoBehaviour
{
    public Transform particle;

    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        HealthScript health = transform.gameObject.GetComponent<HealthScript>();
        DamageRate damageRate = otherCollider.transform.gameObject.GetComponent<DamageRate>();
        if (damageRate != null && !otherCollider.gameObject.tag.Equals("Enemy"))
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