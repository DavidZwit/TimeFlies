using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnHandeler : MonoBehaviour {

    [SerializeField]
    GameObject[] SpawnObjects;
    List<GameObject> ActiveObjects = new List<GameObject>();

    float SpawnRate = 0.5f, moveSpeed = 1, mapWidth = 50, deletePos = 0;
    Vector3 StartPosition = new Vector3(0, 0, 200);

    void FixedUpdate()
    {
        if (Time.time % SpawnRate == 0) {
            print("spawn");
            float randomY = Random.Range(-(mapWidth / 2), (mapWidth / 2));
            int random = (int)Random.Range(0, SpawnObjects.Length);

            ActiveObjects.Add(Instantiate(SpawnObjects[random], 
                new Vector3(randomY, StartPosition.y, StartPosition.z), 
                new Quaternion(0, 0, 0, 0)) as GameObject);
        }

        for (var i = 0; i < ActiveObjects.Count; i++) {
            ActiveObjects[i].transform.Translate(Vector3.forward * -moveSpeed);

            if (ActiveObjects[i].transform.position.z < deletePos) {
                Destroy(ActiveObjects[i]);
                ActiveObjects.Remove(ActiveObjects[i]);
            }
        }
    }
}
