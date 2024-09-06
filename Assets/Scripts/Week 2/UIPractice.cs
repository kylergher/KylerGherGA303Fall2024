using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIPractice : MonoBehaviour
{

    public Toggle toggleUI; //this gives us an empty component in the inspector in unity 
    public Image EchoImage;
    public Image Ansel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (toggleUI.isOn)
        {
            Ansel.rectTransform.localScale += Vector3.one * Time.deltaTime; //multiplying by deltatime is 
        }

    }

    public void ChangedToggleValue(bool toggleValue)
    {
        /* if (toggleValue == true)
        {
            Ansel.gameObject.SetActive(true);
        }
        else if (toggleValue == false)
        {
            Ansel.gameObject.SetActive(false);
        }
            //THE ABOVE IS THE SAME AS BELOW
             Ansel.gameObject.SetActive(toggleValue); */
    }
       
    
}
