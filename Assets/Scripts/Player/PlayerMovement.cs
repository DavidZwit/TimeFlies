using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	private GameObject _Player;
	[SerializeField] private float movementSpeed = 20f;
	private Vector3 _PlayerPos;

	private bool _movePositive = false;
	public bool movePositive
	{
		set {_movePositive = value; }
	}

	private bool _moveNegative = false;
	public bool moveNegative
	{
		set {_moveNegative = value; }
	}
		
	void Start () {
		RenderSettings.fog = true;
	
	}
	

	void Update () {
	
		if (_moveNegative) {
			_PlayerPos.x -= movementSpeed * Time.deltaTime; 
		}
		if (_movePositive) 
		{
			_PlayerPos.x += movementSpeed * Time.deltaTime; 
		}



		transform.position = _PlayerPos;
	}

	public void ChangeTime(float timeSet)
	{
		Time.timeScale = timeSet;
	}
}
