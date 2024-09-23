using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCannon : MonoBehaviour
{

    public GameObject projectile;
    public Transform projectileSpawnPosition;
    public float speed = 750f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireCannon()
    {
        GameObject Go = Instantiate(projectile, projectileSpawnPosition.position, projectileSpawnPosition.rotation);
        
        Go.GetComponent<Rigidbody>().AddForce(Go.transform.forward * speed);
    }
}
