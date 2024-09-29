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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerGuy += Time.deltaTime;
    }

    public void OnEnable ()
    {
        
        if (timerGuy >= timerDuration)
        {
            textbox.SetActive(false);
        }

    }
}
