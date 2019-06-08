using UnityEngine;

public class LifeTimeScript : MonoBehaviour
{
    public float duration = 5f;

    void Start()
    {
        Destroy(gameObject, duration);
    }
}
