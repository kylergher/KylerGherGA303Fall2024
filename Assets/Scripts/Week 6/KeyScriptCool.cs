using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum KeyColor
{
    Bronze, 
    Silver, 
    Gold,
}

public class KeyScriptCool : MonoBehaviour
{

    public PlayerScriptMC PlayerInventory;
    public KeyColor keyColour;
    public DoorScriptOpenUp doorScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter()
    {
        PlayerInventory.addKey(keyColour);
        this.gameObject.SetActive(false);
    }

    
}
