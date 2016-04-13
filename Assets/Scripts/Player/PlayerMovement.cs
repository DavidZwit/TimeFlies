using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	private GameObject _Player;
	[SerializeField] private float movementSpeed = 4f;
	private Vector3 _PlayerPos;

	public static float TimeScale = 0.2f;
	private GameObject _heli;
	private float _heliRotation;
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
		_heli = GameObject.FindGameObjectWithTag ("heli");
		_heliRotation = _heli.transform.rotation.z;
	}
	
	void Update()
	{
		if (_moveNegative) {
			_PlayerPos.x -= movementSpeed *  Time.fixedDeltaTime; 
			_heliRotation += 140 *  Time.fixedDeltaTime;

		} else if (_movePositive) {
			_PlayerPos.x += movementSpeed * Time.fixedDeltaTime; 
			_heliRotation -= 140 * Time.fixedDeltaTime;
		} else {
			if (_heliRotation != 0) 
			{
				if (_heliRotation >= 0) {
					_heliRotation -= 100 * Time.fixedDeltaTime;
				}
				if (_heliRotation <= 0) {
					_heliRotation += 100 * Time.fixedDeltaTime;
				}
			}
		}
		_heliRotation = Mathf.Clamp (_heliRotation, -30, 30);

		transform.position = _PlayerPos;
		_heli.transform.rotation = Quaternion.Euler (0, 0, _heliRotation);
	}

	public void ChangeTime(float timeSet)
	{
		Time.timeScale = timeSet;
	}
}
