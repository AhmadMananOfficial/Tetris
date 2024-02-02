using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingManager : MonoBehaviour
{
	public TMP_Dropdown qualityDropdown;
	public Slider volumeSlider;	
	public AudioSource backgroundMusic;
	
	public Button applyButton; 

	private const string volumePrefKey = "musicVolume";
	private const string qualityPrefKey = "qualityLevel";

	

	private void Awake()
	{
		backgroundMusic = GameObject.FindWithTag("BackgroundMusic").GetComponent<AudioSource>();

		// Load saved settings
		int qualityIndex = PlayerPrefs.GetInt(qualityPrefKey, 3);
		float volume = PlayerPrefs.GetFloat(volumePrefKey, 0.3f);
		
		qualityDropdown.value = qualityIndex;
		
		volumeSlider.value = volume;	
		backgroundMusic.volume = volume;
		
		if (applyButton != null) // Ensure button reference is valid
		{
			applyButton.onClick.AddListener(SaveSettings); // Attach event listener
		}
	}


	void Update()
	{
		if (volumeSlider.value != backgroundMusic.volume)
		{
			backgroundMusic.volume = volumeSlider.value;
		}
	}


	public void SaveSettings()
	{
		// Save settings when apply button is pressed
		PlayerPrefs.SetInt(qualityPrefKey, qualityDropdown.value);
		PlayerPrefs.SetFloat(volumePrefKey, volumeSlider.value);
		PlayerPrefs.Save();
	}
	
}
