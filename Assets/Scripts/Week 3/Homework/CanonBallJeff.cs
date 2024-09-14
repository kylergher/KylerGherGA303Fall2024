using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBallJeff : MonoBehaviour
{
    //This is the script that we will add to the canon/spawn location (ish)

    public GameObject BallPrefab; //This is the object we are spawning
    public Transform BallSpawnLocation; //This is where the ball will spawn 

    public float JeffBallSpeed = 10f; //this is how fast jeff will go 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate(BallPrefab, BallSpawnLocation.position, BallSpawnLocation.rotation);
            go.GetComponent<Rigidbody>().AddForce(go.transform.up *  JeffBallSpeed);
        }
        
    }
}
