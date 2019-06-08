using UnityEngine;

public class PlayerCollideScript : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
    
        if (otherCollider.gameObject.tag.Equals("Enemy"))
        {
            Destroy(transform.gameObject);
        }
    }
}
