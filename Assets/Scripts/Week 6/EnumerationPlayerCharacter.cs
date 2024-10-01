using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum JobType
{
    Fighter, 
    Mage,
    Healer,
    Rogue,
    Monk,
}
public class EnumerationPlayerCharacter : MonoBehaviour
{
    public JobType playerClass; 

    // Start is called before the first frame update
    void Start()
    {
        if(playerClass == JobType.Fighter)
        {
            Debug.Log("RHAAAAAAAAAAAAAAAAAAA");
        }

        if(playerClass == JobType.Mage)
        {
            Debug.Log("Yeah you could say I ponder my orbs (don't ask what my orbs are)");
        }

        if( playerClass == JobType.Healer)
        {
            Debug.Log("None of you even have a basic first aid kit??? Dumbasses??");
        }

        if (playerClass == JobType.Rogue)
        {
            Debug.Log("Sneaky sneaky sneaky sneaky sneaky");
        }

        if (playerClass == JobType.Monk)
        {
            Debug.Log("PUNCH PUNCH PUNCH PUNCH PUNCH");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
