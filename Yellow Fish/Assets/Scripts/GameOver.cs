using UnityEngine;
public class GameOver : MonoBehaviour
{
    public GameObject gameOverSc;

    public void Show() {
        gameOverSc.SetActive(true);
        Time.timeScale = 0f;
    }
}
