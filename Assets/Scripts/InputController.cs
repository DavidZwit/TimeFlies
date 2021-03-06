﻿using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {

	PlayerMovement playerMovement;
	private GameObject _timerObj;

	Timer timer;
	void Start () {

		_timerObj = GameObject.FindGameObjectWithTag ("Timer");
		playerMovement = GetComponent<PlayerMovement> ();
		timer = _timerObj.GetComponent<Timer> ();
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
			//playerMovement.ChangeTime (5f);
			SpawnHandeler.moveSpeed = 5f;
			Swing.speed = 100;
			timer.UpdateTimer (2);
		} 
		else if (Input.GetKey (KeyCode.S)) {
			//playerMovement.ChangeTime (0.2f);
			SpawnHandeler.moveSpeed = 1f;
			Swing.speed = 40;
			timer.UpdateTimer (2);
		} 
		else 
		{
			SpawnHandeler.moveSpeed = 2f;
			Swing.speed = 80;
			timer.UpdateTimer (1);
			//playerMovement.ChangeTime (1f);
		}

	}
}
