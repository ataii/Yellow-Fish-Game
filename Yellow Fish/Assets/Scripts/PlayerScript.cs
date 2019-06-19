using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Animator animator;
    public HealthScript health;
    public ShotScript shotScript;
    public GameObject gameOverSc;
    public Transform bulletPrefab;
    public float cooldown = 0.25f;
    public float rotateSpeed = 5f;

    private float oldRotation;
    private float newRotation;

    private void Start()
    {
        shotScript.animator = animator;
        shotScript.bulletPrefab = bulletPrefab;
        shotScript.cooldown = cooldown;
    }

    void Update()
    {
        RotateToMousePosition();
        PlayRotationAnimation();
    }
    
    void RotateToMousePosition()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; 
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);  
        oldRotation = transform.rotation.z;
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotateSpeed * Time.deltaTime);
        newRotation = transform.rotation.z;
    }
    
    void PlayRotationAnimation()
    {
        if (oldRotation > newRotation)
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

    public void ShowGameOver()
    {
        Time.timeScale = 0f;
        gameOverSc.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        DamageRate damageRate = otherCollider.transform.gameObject.GetComponent<DamageRate>();
        if (damageRate != null && otherCollider.gameObject.tag.Equals("Enemy"))
        {
            health.Damage(damageRate.damage);
            if (health.IsDead())
            {
                ShowGameOver();
            }
        }
    }
}
