using UnityEngine.Tilemaps;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
	public AudioClip dropSound;
	public AudioClip rotationSound;
	
	private AudioSource audioSource;
	
	
    void Start()
    {
	    audioSource = GetComponent<AudioSource>();
    }

    
	public void DropSound()
	{
		audioSource.PlayOneShot(dropSound);
	}
	
	public void RotationSound()
	{
		audioSource.PlayOneShot(rotationSound);
	}
	
}
