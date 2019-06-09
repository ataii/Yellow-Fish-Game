using UnityEngine;

public class BlueFishOpenMouthAnimation : MonoBehaviour
{
    public Animator animator;

    public void SetStartValueForAnimation(bool isOpen)
    {
        animator.SetBool("isOpen", isOpen);
    }
}
