using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

	public GameManager gameManager;

	void OnTriggerEnter() 
	{
		gameManager.EndLevel ();
	}
}
