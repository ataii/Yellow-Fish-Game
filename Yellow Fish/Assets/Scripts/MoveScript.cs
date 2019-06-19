using UnityEngine;

public class MoveScript : MonoBehaviour
{
    [HideInInspector] public float speed;

    void Update()
    {
        Move();
    }

    public void Move() { 
        this.transform.Translate(speed * Time.deltaTime, 0f, 0f);
    }
}
