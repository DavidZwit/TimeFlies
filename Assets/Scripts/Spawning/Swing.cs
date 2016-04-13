using UnityEngine;
using System.Collections;

public class Swing : MonoBehaviour {

    bool returning = false;
    public static int speed = 80;

	void Update()
    {
        if (!returning) {
            transform.Rotate(new Vector3(0, 0, (transform.rotation.z + speed) * Time.deltaTime));
            if (transform.rotation.z > 0.6f) returning = true;
        } else {
            transform.Rotate(new Vector3(0, 0, (transform.rotation.z - speed) * Time.deltaTime));
            if (transform.rotation.z < -0.6) returning = false;
        }
    }
}
