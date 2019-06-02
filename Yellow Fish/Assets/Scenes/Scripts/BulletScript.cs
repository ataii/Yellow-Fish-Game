using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float duration = 5f;

    void Start()
    {
        Destroy(gameObject, duration);
    }
}
