using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScriptWrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoorOpeningNow()
    {
        this.transform.Translate(Vector3.up * 10f);
    }
}
