using UnityEngine;

public class BubbleScript : MonoBehaviour
{
    public MoveScript move;
    public DamageRate damageRate;
    public int damage;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        move.speed = speed;
        damageRate.damage = damage;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.gameObject.tag.Equals("Enemy"))
        {
            Destroy(transform.gameObject);
        }
    }

}
