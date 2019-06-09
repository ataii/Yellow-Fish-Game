using UnityEngine;

public class BlueFishOpenMouthAnimation : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("LunchZone"))
            animator.SetBool("isOpen", true);
    }
}
