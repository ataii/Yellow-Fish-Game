using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectSceneScript : MonoBehaviour
{
    public void LoadScene(int level)
    {
        SceneManager.LoadScene(level);
    }
}
