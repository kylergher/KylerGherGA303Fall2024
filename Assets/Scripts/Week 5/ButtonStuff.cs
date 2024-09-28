using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

public class ButtonStuff : MonoBehaviour
{
    public GameObject StartingText;
    public GameObject DontPressMe;
    public float textTimer = 0f;
    public float timerDuration = 3f;
    public GameObject newButton;
    public bool hasTimerGoneOff = false;
  

    public List<GameObject> cubes = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        StartingText.SetActive(true);
        DontPressMe.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        //timers are put in update
        textTimer += Time.deltaTime;

        if (textTimer >= 2f && hasTimerGoneOff == false)
        {
            Debug.Log("Hey man im awake");
            DontPressMe.SetActive(true);
            hasTimerGoneOff = true;
        }

    }
    public void ClickOnce()
    {
        DontPressMe.SetActive(false);
    }


    
    public void EnableCubes()
    {
        for (int i = 0; i < cubes.Count; i++)
        {
            cubes[i].SetActive(true);

            if (i < 2)
            {
                cubes[i].transform.localScale += Vector3.one;
            }

            if (i >= 2 && i < 4)
            {
                cubes[i].transform.position += Vector3.up;
            }

            if(i >= 4 && i <= 5)
            {
                cubes[i].transform.position -= Vector3.up;
            }

           /* if(i > 5 && i <= 7)
            {
                cubes[i].transform.localScale /= 2;
            }*/
           if(i == 6 || i == 7)
            {
                cubes[i].transform.localScale /= 2;
            }
        }

        foreach (GameObject cube in cubes)
        {
            cube.SetActive(true);
        }
    }
    
}
