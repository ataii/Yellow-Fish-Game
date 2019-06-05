using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleCollideScript : MonoBehaviour, ICollidable
{
    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (!otherCollider.gameObject.tag.Equals("Player"))
        {
            Destroy(transform.gameObject);
        }
    }
}
