using UnityEngine;

public class ShotScript : MonoBehaviour
{
    public Transform bulletPrefab;
    public float cooldown = 0.25f;

    private float shootCooldown;

    public void Attack()
    {
        var shotTransform = Instantiate(bulletPrefab) as Transform;
        shotTransform.position = transform.position;
        shotTransform.rotation = transform.rotation;
    }

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
        if (CanAttack)
        {
            shootCooldown = cooldown;
        if (Input.GetMouseButton(0))
        {
            this.Attack();
            Debug.Log("attak!");
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
}
