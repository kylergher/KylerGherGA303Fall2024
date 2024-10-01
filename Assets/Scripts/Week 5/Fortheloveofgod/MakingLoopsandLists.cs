using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingLoopsandLists : MonoBehaviour
{
    public List<GameObject> guys = new List<GameObject>();

    public GameObject thingAppliedTo;
    public GameObject doThisThing;
    public GameObject youCanNow;

    void Start()
    {
        doThisThing.SetActive(false);
        youCanNow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (thingAppliedTo.tag == "hasKey")
        {
            doThisThing.SetActive(true);
            Debug.Log("Oh hey you have what you need, yay");
            newCommand();
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            enableObjects();
            youCanNow.SetActive(true);
            thingAppliedTo.tag = "JeffTag";
        }

        if (thingAppliedTo.tag == "JeffTag")
        {
            if(Input.GetKeyDown(KeyCode.T))
            {
                enableObjects();
            }
        }

    }

    public void enableObjects()
    {
       
        foreach (GameObject go in guys)
        {
            go.SetActive(true);
        }

        for (int i = 0; i < guys.Count; i++)
         {
            guys[i].SetActive(true);

            if (i < 2)
            {
                guys[i].transform.localScale += Vector3.one;
            }

            if (i >= 2 && i < 4)
            {
                guys[i].transform.position += Vector3.up;
            }

            if (i >= 4 && i <= 5)
            {
                guys[i].transform.position -= Vector3.up;
            }

            if (i == 6 || i == 7)
            {
                guys[i].transform.localScale /= 2;
            }
        }


    }

    

    public void newCommand()
    {
        thingAppliedTo.tag = "usedKey";
    }
}
