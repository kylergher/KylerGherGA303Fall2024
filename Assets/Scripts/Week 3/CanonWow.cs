using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonWow : MonoBehaviour
{
    public GameObject cannonball; //this is the object we will spawn 
    public Transform cannonballspawnlocation; //thisiswhere our cannonball will spawn 

    public float cannonBallSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(cannonball, cannonballspawnlocation.position, cannonballspawnlocation.rotation);

            go.GetComponent<Rigidbody>().AddForce(go.transform.forward * cannonBallSpeed);
        }
        
    }
}
