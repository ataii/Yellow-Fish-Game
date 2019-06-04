using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    public float rotateSpeed = 5f;

    void Update()
    {
        RotateToMousePosition();
    }

    void RotateToMousePosition()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position; //Get direction to mouse position
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // Get Angle in degrees
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);  // Set rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotateSpeed * Time.deltaTime); // Interpolation for smooth movement with speed settnigs
    }

}
