using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	[SerializeField]
	private float _timer;

	private float _timerDescrease;

	[SerializeField]private Text _text;

	void Start () 
	{
			}
		
	void Update () 
	{
		if (_timer > 0) {
			_timer -= Time.deltaTime;
		}

		int a = (int) Mathf.Round (_timer);
		_text.text = "" + a;
	}


}
