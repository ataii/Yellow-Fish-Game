using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    public float rotateSpeed = 5f;
    public Animator animator;

    private float oldRotation;
    private float newRotation;

    void Update()
    {
        RotateToMousePosition();
        PlayRotationAnimation();
    }

    void RotateToMousePosition()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position; //Get direction to mouse position
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // Get Angle in degrees
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);  // Set rotation
        oldRotation = transform.rotation.z;
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotateSpeed * Time.deltaTime); // Interpolation for smooth movement with speed settnigs
        newRotation = transform.rotation.z;
    }

    void PlayRotationAnimation()
    {
        if(oldRotation > newRotation)
        {
            animator.SetInteger("rotation", -1);
        }
        if (oldRotation < newRotation)
        {
            animator.SetInteger("rotation", +1);
        }
        if (oldRotation.Equals(newRotation))
        {
            animator.SetInteger("rotation", 0);
        }
    }

}
