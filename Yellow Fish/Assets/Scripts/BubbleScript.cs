using UnityEngine;

public class BubbleScript : MonoBehaviour
{
    public MoveScript move;
    public DamageRate damageRate;
    public int damage;
    public float speed;

    void Start()
    {
        move.speed = speed;
        damageRate.damage = damage;
    }

    void OnBecameInvisible()
    {
        transform.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.gameObject.tag.Equals("Enemy"))
        {
            transform.gameObject.SetActive(false);
        }
    }

}
