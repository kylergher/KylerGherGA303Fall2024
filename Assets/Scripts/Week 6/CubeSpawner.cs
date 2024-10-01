using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{

    public Transform initialSpawnPosition;
    public GameObject spawnPrefab;
    public int spawnCount = 0;
    //public int spawnSpaceInterval = 5;
    // public Vector3 spaceBetweenCubes;

    public int maxPublicRange = 10;

    // Start is called before the first frame update
    void Start()
    {
        
        for(int i=0; i<spawnCount; i++)
        {
            //GameObject spawnedObject = Instantiate(spawnPrefab, initialSpawnPosition.position, initialSpawnPosition.rotation);
            //spawnedObject = local variable. when function finsihes, the local variable kills itself 
            int randomX = Random.Range(1, maxPublicRange + 1);
            int randomY = Random.Range(1, maxPublicRange + 1);
            int randomZ = Random.Range(1, maxPublicRange + 1);

            Vector3 randomMoveDistance = new Vector3(randomX, randomY, randomZ);
            GameObject spawnedThings = Instantiate(spawnPrefab, initialSpawnPosition.position, initialSpawnPosition.rotation);
            //spawnedObject.transform.Translate(spaceBetweenCubes * i);
            spawnedThings.transform.Translate(randomMoveDistance);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
