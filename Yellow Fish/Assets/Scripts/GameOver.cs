using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverSc;

    public void show()
    {
        Time.timeScale = 0f;
        gameOverSc.SetActive(true);
    }
}
