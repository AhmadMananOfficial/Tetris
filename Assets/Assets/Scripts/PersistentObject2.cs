using UnityEngine;

public class PersistentObject2 : MonoBehaviour
{
	private static PersistentObject2 _instance;

	private void Awake()
	{
		if (_instance == null)
		{
			_instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else if (_instance != this)
		{
			Destroy(gameObject);
		}
	}
}