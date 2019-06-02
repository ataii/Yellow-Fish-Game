using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        Move();
    }

    public void Move() { 
        this.transform.Translate(speed * Time.deltaTime, 0f, 0f);
    }
}
