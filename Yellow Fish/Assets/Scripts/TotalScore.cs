using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{
    Text totalScore;

    void Start()
    {
        totalScore = GetComponent<Text>();
        totalScore.text = "TOTAL SCORE: " + ScoreCounterScript.scoreValue;
    }

}
