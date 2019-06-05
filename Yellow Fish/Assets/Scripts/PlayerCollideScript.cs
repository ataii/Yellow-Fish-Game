using UnityEngine;

public class PlayerCollideScript : MonoBehaviour, ICollidable
{
    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.gameObject.tag.Equals("Enemy"))
        {
            Destroy(transform.gameObject);
        }
    }
}
