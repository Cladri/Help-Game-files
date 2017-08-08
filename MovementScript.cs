using UnityEngine;


public class MovementScript : MonoBehaviour {

	public Rigidbody rb;
	public float ForwardsForce = 1000f;
	public float SidewaysForce = 50f;
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		rb.AddForce (0, 0, ForwardsForce * Time.deltaTime);

		if (Input.GetKey ("d") ) 
		{
			rb.AddForce (SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey ("a") ) 
		{
			rb.AddForce (-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rb.position.y < -1) 
		{
			FindObjectOfType<GameManager> ().EndGame ();
		
		}

	}



}

