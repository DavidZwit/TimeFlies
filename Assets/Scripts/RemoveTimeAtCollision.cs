using UnityEngine;
using System.Collections;

public class RemoveTimeAtCollision : MonoBehaviour {
    [SerializeField]
    int timeChange;
    [SerializeField]
    string collTag;

    Timer timeClass;

    void Start() {  
		timeClass = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
 
	}

	void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Health")
        {
			Debug.Log ("vruchtenSap" + coll.gameObject.name);
			timeClass.UpdateTimer (-500);
        }
		if (coll.gameObject.tag == "Damage") 
		{
			
			Debug.Log ("AppelSap" + coll.gameObject.name);
			timeClass.UpdateTimer (500);
		}
    }
}
