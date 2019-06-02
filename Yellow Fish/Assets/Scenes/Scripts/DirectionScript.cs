using UnityEngine;

public class DirectionScript : MonoBehaviour
{
    public float rotateSpeed = 15f;
    public Transform target;

    void Update()
    {
        Vector2 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        //Debug.Log(Quaternion.AngleAxis(angle, Vector3.forward));
    }
}
