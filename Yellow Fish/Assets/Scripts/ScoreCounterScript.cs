using UnityEngine;
using UnityEngine.UI;

public class ScoreCounterScript : MonoBehaviour
{
    public static int scoreValue;
    Text score;

    private void Start()
    {
        scoreValue = 0;
        score = GetComponent<Text>();
    }

    private void Update()
    {
        score.text = "Score: " + scoreValue;
    }
}
