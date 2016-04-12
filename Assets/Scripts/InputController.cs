﻿using UnityEngine;
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
			playerMovement.ChangeTime (2f);
		} 
		else if (Input.GetKey (KeyCode.S)) {
			playerMovement.ChangeTime (0.4f);
		} 
		else 
		{
			playerMovement.ChangeTime (1f);
		}
	}
}
