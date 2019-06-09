using UnityEngine;

public class PlayerCollideScript : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameOver gameOver = transform.gameObject.GetComponent<GameOver>();
        HealthScript health = transform.gameObject.GetComponent<HealthScript>();
        DamageRate damageRate = otherCollider.transform.gameObject.GetComponent<DamageRate>();
        if (damageRate != null && otherCollider.gameObject.tag.Equals("Enemy"))
        {
            health.Damage(damageRate.damage);
            if (health.IsDead())
            {
                gameOver.show();
                Destroy(transform.gameObject);
            }
        }
    }
}
