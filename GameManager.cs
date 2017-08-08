using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public float restartDelay = 2f;
	bool GameHasEnded = false;
	public GameObject levelCompleteUI;


	public void EndGame() 
	{
		if (GameHasEnded == false) 
		{
			GameHasEnded = true;
			Invoke ("Restart", restartDelay);

		} 
	
	}
	void Restart() 
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	public void EndLevel() 
	{
		levelCompleteUI.SetActive (true);
	
	}


}

