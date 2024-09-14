using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBallBeff : MonoBehaviour
{
    //This is the script that we will add to the canon/spawn location (ish)

    public GameObject Ball2; //This is the object we are spawning
    public Transform SpawnLocation; //This is where the ball will spawn 

    public float BeffBallSpeed = 10f; //this is how fast jeff's brother beff will go 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.setActive == true)
        {
            GameObject go = Instantiate(Ball2, SpawnLocation.position, SpawnLocation.rotation);
            go.GetComponent<Rigidbody>().AddForce(go.transform.up *  BeffBallSpeed);
        }
        
    }
}
