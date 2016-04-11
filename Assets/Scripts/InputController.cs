using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {

	PlayerMovement playerMovement;

	void Start () {


		playerMovement = GetComponent<PlayerMovement> ();
	}
	
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
