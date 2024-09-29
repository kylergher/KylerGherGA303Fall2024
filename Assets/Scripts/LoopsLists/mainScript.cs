using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using NUnit.Framework.Constraints;

public class UIScript : MonoBehaviour
{
    public GameObject door;
    public GameObject desk;
    public GameObject wardrobe;
    public TextMeshProUGUI openingText;
    public TextMeshProUGUI instructionText;
    public float timerDuration = 1.2f;
    public float timer;
    public float tooMuchTime = 4f;
    public TextMeshProUGUI oops;
    public float timerDuration2;
    public float timer2;
    

    // Start is called before the first frame update
    void Start()
    {
        openingText.gameObject.SetActive(false);
        instructionText.gameObject.SetActive(false);
        oops.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer2 += Time.deltaTime;
        timer += Time.deltaTime;
        if (timer >= timerDuration)
        {
            openingText.gameObject.SetActive(true);
        }

        if (timer >= tooMuchTime && openingText.gameObject.activeSelf == true)
        {
            openingText.gameObject.SetActive(false);
            instructionText.gameObject.SetActive(true);
            
            if(timer >= 5f)
            {
                instructionText.gameObject.SetActive(false);
            }

        }

        if (timer >= 3f && openingText.gameObject.activeSelf == false &&  instructionText.gameObject.activeSelf == false)
        {
            pressSpace();
            
        }
       
       
    }
    public void pressSpace()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("You need a key");
            oops.gameObject.SetActive(true);
           
        }
    }
}

