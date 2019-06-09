using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public int hp = 1;

    private bool death = false;

    public void Damage(int damageCount)
    {
        hp -= damageCount;
        death = (hp <= 0);
    }

    public bool IsDead()
    {
        return death;
    }
}
