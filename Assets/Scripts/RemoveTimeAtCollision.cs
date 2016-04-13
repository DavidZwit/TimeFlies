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

    void OnCollisionEnter(Collision coll)
    {
		Debug.Log ("Ik collide met" + coll.gameObject.tag);
        if (coll.gameObject.tag == collTag)
        {
			Debug.Log ("It happend");
            timeClass.timerDecrease += timeChange;
        }
    }
}
