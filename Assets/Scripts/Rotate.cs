using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	private float _rotation;
	private Quaternion _GameRotation;
	private GameObject _parent;
	// Use this for initialization
	void Start () {
		_GameRotation = this.transform.rotation;
		_rotation = _GameRotation.y;
		_parent = GameObject.FindGameObjectWithTag ("heli");
	}
	
	// Update is called once per frame
	void Update () {
		_rotation = 720;
		transform.Rotate (new Vector3 (0, _rotation,0)*Time.deltaTime);
	}
}
