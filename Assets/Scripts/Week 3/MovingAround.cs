using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAround : MonoBehaviour
{
    public GameObject spawnedPrefab;
    public Transform otherSpawnLocation;
    

    // Start is called before the first frame update
    void Start()
    {

        GameObject jeff = Instantiate(spawnedPrefab);

        jeff.GetComponent<Light>().color = Color.blue;

        Instantiate(spawnedPrefab, this.transform.position, this.transform.rotation);
       // Instantiate(spawnedPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject jeffAgain = Instantiate (spawnedPrefab);
            jeffAgain.GetComponent<Light>().color = Color.red;
        }

        if(Input.GetKeyUp(KeyCode.P))
        {
            GameObject jeffthree = Instantiate(spawnedPrefab, this.transform.position, this.transform.rotation);
            jeffthree.GetComponent<Light>().color = Color.green;
        }
        
        
    }
    public void CreateJeff()

        {

        }
}
