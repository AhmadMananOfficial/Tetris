using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
	public int pointsPerLine = 10;

	[SerializeField] private TextMeshProUGUI scoreText;
	[SerializeField] private TextMeshProUGUI highScoreText;
	int currentScore;
	
	void Start()
	{
		currentScore = 0;
		int highScore = PlayerPrefs.GetInt("highScore", 0);
		highScoreText.text = highScore.ToString();
	}
	
	
	public void UpdateScore()
	{
		currentScore += pointsPerLine;
		scoreText.text = currentScore.ToString();
		
		// Check for new high score
		CheckForHighScore();
	}
	
	
	void CheckForHighScore()
	{
		int savedHighScore = PlayerPrefs.GetInt("highScore", 0);
		if (currentScore > savedHighScore)
		{
			PlayerPrefs.SetInt("highScore", currentScore);
			highScoreText.text = currentScore.ToString();
		}
	}
	
	public void OnGameOver() // Triggered when game over occurs
	{
		PlayerPrefs.SetInt("currentScore", currentScore);
	}
}
