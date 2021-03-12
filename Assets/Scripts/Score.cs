using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text bestScoreText;

    private int score;

    private void Start()
    {
        //Start the game with best score being displayed
        bestScoreText.text = "Best Score\n" + PlayerPrefs.GetInt("BestScore", 0).ToString();
        score = 0;
    }

    //Add and update score
    public void AddScore()
    {
        score++;
        UpdateScoreText();
    }

    //Update score and best score texts
    private void UpdateScoreText()
    {
        scoreText.text = "Score\n" + score.ToString();

        if(score > PlayerPrefs.GetInt("BestScore", 0))
        {
            PlayerPrefs.SetInt("BestScore", score);
            bestScoreText.text = "Best Score\n" + score.ToString();
        }
    }
}
