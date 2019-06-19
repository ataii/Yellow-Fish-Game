using UnityEngine;

public class ShotScript : MonoBehaviour
{
    [HideInInspector] public float cooldown = 0.25f;
    [HideInInspector] public Animator animator;
    [HideInInspector] public Transform bulletPrefab;

    private float shootCooldown;


    private void Start()
    {
        shootCooldown = 0f;
    }

    private void Update()
    {
        if (shootCooldown > 0)
        {
            shootCooldown -= Time.deltaTime;
        }
        animator.SetBool("Shooting", Input.GetMouseButton(0));

        if (shootCooldown <= 0f)
        {
            if (Input.GetMouseButton(0))
            {
                Attack();
                shootCooldown = cooldown;
            }
        }
    }

    public void Attack()
    {
        Transform shotTransform = Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}
