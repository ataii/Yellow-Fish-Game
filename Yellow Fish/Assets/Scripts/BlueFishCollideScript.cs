using UnityEngine;

public class BlueFishCollideScript : MonoBehaviour
{
    public Transform blood;

    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        HealthScript health = transform.gameObject.GetComponent<HealthScript>();
        DamageRate damageRate = otherCollider.transform.gameObject.GetComponent<DamageRate>();
        if (damageRate != null)
        {
            health.Damage(damageRate.damage);
            Destroy(damageRate.transform.gameObject);
            if (health.IsDeath())
            {
                Instantiate(blood, transform.position, Quaternion.identity);
                Destroy(transform.gameObject);
            }
        }
    }
}