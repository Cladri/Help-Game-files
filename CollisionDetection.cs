using UnityEngine;


public class CollisionDetection : MonoBehaviour {

	public MovementScript movementScript;
	public Transform player;
	public Rigidbody rb;

	void OnCollisionEnter(Collision collisionInfo) 
	{
		if (collisionInfo.collider.tag == "Obstacle") 
		{
			movementScript.enabled = false;
			FindObjectOfType<GameManager> ().EndGame ();
		}

	}


}
