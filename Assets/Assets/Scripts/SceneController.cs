using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{

	public GameObject pausedPanel;
	
	bool isPaused;
	

	public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}

	public void PlayGame()
	{
		LoadScene("Game"); // Game is the name of Level 01 scene name 
	}

	public void Settings()
	{
		// Implement settings functionality here
	}

	public void PauseGame()
	{
		isPaused = true;
		Time.timeScale = 0; 
		pausedPanel.SetActive(true);
	}

	public void ResumeGame()
	{
		isPaused = false;
		Time.timeScale = 1;
		if(pausedPanel != null)
		{
			pausedPanel.SetActive(false);
		}
		
	}

	public void RestartGame()
	{
		SceneManager.LoadScene("Game");
		ResumeGame();
	}

	public void MainMenu()
	{
		LoadScene("Main Menu");
		ResumeGame();
	}
	
	public void QuitGame()
	{
		Application.Quit(); 
	}
}
	

	
	
	
	

