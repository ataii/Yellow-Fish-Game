using UnityEngine;
using System.Collections;

public interface ICollidable
{
    void OnTriggerEnter2D(Collider2D otherCollider);
}
