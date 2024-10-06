using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SomehowEvenMoreLoops : MonoBehaviour
{
    public bool hasPlayerBeenEliminated = false;
    public bool isNextObjectHoneycomb = true;

   


    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            dropFruit(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            dropFruit(2);
        }


    }

    public void dropFruit(int numObjectsDropped)
    {
        for (int i = 0; i < numObjectsDropped; i++)
        {
            {
                if (isNextObjectHoneycomb)
                {
                    Debug.Log("Player is eliminated");
                    //Object in list is destroyed and removed from list, and player is eliminated
                    hasPlayerBeenEliminated = true;

                }

                if (hasPlayerBeenEliminated == true)
                {
                    break; //break means we want to break out of the loop rn, do not go around again, do not press go
                }
            }
            Debug.Log("Going through" + i + "times");

            //Run the rest of the code after the break

        }
    }
}