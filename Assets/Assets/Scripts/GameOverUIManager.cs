using UnityEngine;
using TMPro;

public class GameOverUIManager : MonoBehaviour
{
	public TMP_Text scoreText;
	public TMP_Text highScoreText;
	
	void Start()
	{
		int currentScore = PlayerPrefs.GetInt("currentScore", 0);
		int highScore = PlayerPrefs.GetInt("highScore", 0);

		scoreText.text = currentScore.ToString();
		highScoreText.text = highScore.ToString();

		// Optionally reset current score:
		PlayerPrefs.SetInt("currentScore", 0);

	}
}
