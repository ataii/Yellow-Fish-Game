using UnityEngine;

public class ShotScript : MonoBehaviour
{
    public float cooldown = 0.25f;
    public Animator animator;
    public Transform bulletPrefab;

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
    }

    void FixedUpdate()
    {
        animator.SetBool("Shooting", Input.GetMouseButton(0));

        if (CanAttack)
        {
            if (Input.GetMouseButton(0))
            {
            this.Attack();
            shootCooldown = cooldown;
            }
        }
    }

    public bool CanAttack
    {
        get
        {
            return shootCooldown <= 0f;
        }
    }

    public void Attack()
    {
        Transform shotTransform = Instantiate(bulletPrefab);
        shotTransform.position = transform.position;
        shotTransform.rotation = transform.rotation;
    }
}
