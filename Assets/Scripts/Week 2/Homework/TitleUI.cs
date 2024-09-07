using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UI;

public class TitleUI : MonoBehaviour
{
    public Image CharlieImage;
    public Toggle ShinyButton;
    public Sprite ChangeEmotion;
    public Image CarlisleC;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    public void ToggleOnOff(bool toggleValue)
    {
        if (toggleValue == true)
        {
            CharlieImage.gameObject.SetActive(true);
        }
        else if (toggleValue == false)
        {
            CharlieImage.gameObject.SetActive(false);
        }
    }



    public void SlideThatBoyIn()
         { 
            if (ShinyButton.isOn)
                    {
                        CharlieImage.rectTransform.Translate(691f, -235f, 0f);

                    }    
         }
}
