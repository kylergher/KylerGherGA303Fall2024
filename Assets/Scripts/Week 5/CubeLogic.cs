using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLogic : MonoBehaviour
{
    public float timeToDie = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, timeToDie);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
