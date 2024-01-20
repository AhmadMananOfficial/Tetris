using UnityEngine;

public class PersistentObject1 : MonoBehaviour
{
	private static PersistentObject1 _instance;

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

