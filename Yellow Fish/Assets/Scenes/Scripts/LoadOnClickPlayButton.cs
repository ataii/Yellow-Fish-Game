using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClickPlayButton : MonoBehaviour
{
    public void LoadGame(int level)
    {
        SceneManager.LoadScene(level);
    }
}
