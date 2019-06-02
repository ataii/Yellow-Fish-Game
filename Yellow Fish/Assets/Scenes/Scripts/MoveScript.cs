using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float speed;

    private void FixedUpdate()
    {
        this.transform.Translate(speed * Time.deltaTime, 0f, 0f);
    }
}
