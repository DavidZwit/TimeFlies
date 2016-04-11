using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {

	PlayerMovement playerMovement;

	// Use this for initialization
	void Start () {


		playerMovement = GetComponent<PlayerMovement> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
		playerMovement.moveNegative = true;
		} else {
		playerMovement.moveNegative = false;
		}
		if (Input.GetKey (KeyCode.D)) {
			playerMovement.movePositive = true;
		} else {
			playerMovement.movePositive = false;
		}
		if (Input.GetKey (KeyCode.W)) {
			Debug.Log ("Ik ga kenker snel");
			playerMovement.ChangeTime (4f);
		} 
		if (Input.GetKey (KeyCode.S)) {
			playerMovement.ChangeTime (0.4f);
		} 
		if (Input.GetKey (KeyCode.R)) 
		{
			playerMovement.ChangeTime (1f);
		}
	}
}
