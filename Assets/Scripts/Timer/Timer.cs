using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	[SerializeField]
	private float _timer;

	private float _timerDecrease = 1f;
	public float timerDecrease
	{
		set{ _timerDecrease = value; }
	}
	[SerializeField]private Text _text;

	void Start () 
	{
			}
		
	void Update () 
	{
		if (_timer > 0) {
			_timer -= (Time.deltaTime * _timerDecrease);
		}

		int a = (int) Mathf.Round (_timer);
		_text.text = "" + a;
	}


}
