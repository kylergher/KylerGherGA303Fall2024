using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleaseForTheLoveofGod : MonoBehaviour
{
    public GameObject holyShitAKey;
    public GameObject instructionText;

    public GameObject attachedGameObject;

    public GameObject itemConfirmed;

    void Start()
    {
        holyShitAKey.SetActive(false);
        instructionText.SetActive(false);

        itemConfirmed.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        isKeyOn();

        if(holyShitAKey.gameObject.activeSelf == true)
        {
            instructionText.SetActive(true);
            Debug.Log("You got this");
        }

        callThisNow();
    }

    public void isKeyOn()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            holyShitAKey.SetActive(true);
            Debug.Log("It's working you're doing it right");
        }
    }

    public void callThisNow()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            holyShitAKey.SetActive(false);
            instructionText.SetActive(false);
            Debug.Log("You have a key now");

            itemConfirmed.SetActive(true);
            attachedGameObject.tag = "hasKey";
        }
    }
}
