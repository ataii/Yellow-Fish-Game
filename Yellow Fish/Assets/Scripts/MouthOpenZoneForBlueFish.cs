using UnityEngine;

public class MouthOpenZoneForBlueFish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        BlueFishOpenMouthAnimation openMouthAnimation = collision.transform.gameObject.GetComponent<BlueFishOpenMouthAnimation>();
        openMouthAnimation.SetStartValueForAnimation(true);
    }
}
