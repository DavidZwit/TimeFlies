using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnHandeler : MonoBehaviour {

    [SerializeField]
    GameObject[] SpawnObjects;
    List<GameObject> ActiveObjects = new List<GameObject>();

    [SerializeField]
    float SpawnRate = 0.01f, moveSpeed = 1, mapWidth = 50, deletePos = 0, spawnAmound = 10;

    [SerializeField]
    Vector3 StartPosition = new Vector3(0, 0, 1000);

    [SerializeField]
    Transform playerPosition;


    void FixedUpdate()
    {
        if (Time.time % SpawnRate == 0) {
            for (int i = 0; i < spawnAmound; i++)
            {
                float randomX = Random.Range(-(mapWidth / 2), (mapWidth / 2)) + playerPosition.position.x;
                int random = (int)Random.Range(0, SpawnObjects.Length);
                print(StartPosition.z);
                ActiveObjects.Add(Instantiate(SpawnObjects[random],
                    new Vector3(randomX, StartPosition.y, StartPosition.z),
                    new Quaternion(0, 0, 0, 0)) as GameObject);
            }
        }

        for (var i = 0; i < ActiveObjects.Count; i++) {
            ActiveObjects[i].transform.Translate(Vector3.forward * -moveSpeed);
            Vector3 activeObjectPosition = ActiveObjects[i].transform.position;
            Vector2 SpawnBoundries = new Vector2(
                playerPosition.position.x - (mapWidth / 2), 
                playerPosition.position.x + (mapWidth / 2));

            if (activeObjectPosition.z < deletePos || 
                activeObjectPosition.x < SpawnBoundries.x || 
                activeObjectPosition.x > SpawnBoundries.y) {

                Destroy(ActiveObjects[i]);
                ActiveObjects.Remove(ActiveObjects[i]);
            }
        }
    }
}
