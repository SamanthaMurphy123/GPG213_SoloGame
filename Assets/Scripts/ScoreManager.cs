using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update the score and display it on the canvas
    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score.ToString();
    }
}
