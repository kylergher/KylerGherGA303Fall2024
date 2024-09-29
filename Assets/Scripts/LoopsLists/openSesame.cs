using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class openSesame : MonoBehaviour
{
    public float dialogueTimer;
    public float timerCap = 3f;
    public GameObject textBoxt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void textTimer ()
    {
        if(dialogueTimer >= timerCap)
        {
            textBoxt.SetActive(false);
        }
    }
}
