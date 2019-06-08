using UnityEngine;
using UnityEngine.UI;

public class ScoreCounterScript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;

    private void Start()
    {
        score = GetComponent<Text>();
    }

    private void Update()
    {
        score.text = "Score: " + scoreValue;
    }
}
