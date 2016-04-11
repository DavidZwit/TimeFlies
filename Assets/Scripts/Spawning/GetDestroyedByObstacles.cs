using UnityEngine;
using System.Collections;

public class GetDestroyedByObstacles : MonoBehaviour {

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Damage")
        {
            Destroy(gameObject);
        }
    }
}
