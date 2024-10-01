using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timerScript : MonoBehaviour
{
    public float timerGuy;
    public float timerDuration = 2f;
    public GameObject textbox;
    public GameObject pressE;

    void Start()
    {
        pressE.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timerGuy += Time.deltaTime;
        OnEnable();

        
    }

    public void OnEnable ()
    {
        
        if (timerGuy >= timerDuration)
        {
            textbox.SetActive(false);
            timerGuy = 0f;
            pressE.SetActive(true);
            newText();
        }

    }

    public void newText()
    {
        
    }
}
