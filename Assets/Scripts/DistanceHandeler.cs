using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DistanceHandeler : MonoBehaviour {

    float distanceTraveled;
    int timeScalar = 205;

    [SerializeField]
    Text distanceText;


    void FixedUpdate()
    {
        distanceText.text = "Distance: " + Mathf.Round((distanceTraveled += Time.deltaTime * timeScalar));
    }
}
