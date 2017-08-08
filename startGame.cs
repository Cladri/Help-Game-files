using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour {


	public void LoadLevel () 
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

}
