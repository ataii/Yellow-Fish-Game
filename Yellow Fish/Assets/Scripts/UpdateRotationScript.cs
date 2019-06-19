using UnityEngine;

public class UpdateRotationScript : MonoBehaviour
{
    [HideInInspector] public GameObject target;

    void Update()
    {
       Rotation();
    }

    void Rotation()
    {
        Vector2 direction = target.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        //Debug.Log(Quaternion.AngleAxis(angle, Vector3.forward));
    }
}
