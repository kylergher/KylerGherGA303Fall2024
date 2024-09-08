using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageToggleScript : MonoBehaviour
{
    public Image image1;
    public Image image2;
    private Sprite originalSprite;
    public Sprite swappedspriteBright;
    public LightChange Changeslight;
   

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hey dude i need to fix something");
       
       image1.gameObject.SetActive(false);
        image2.gameObject.SetActive(true);

        originalSprite = image2.sprite;

        Changeslight.Yelling();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPress()
    {
        Debug.Log("The button is being pressed");
        /* if (image1.gameObject.activeSelf == true)
        {
            image1.gameObject.SetActive(false);
        }
        else if (image1.gameObject.activeSelf == false)
        {
            image1.gameObject.SetActive(true);
        }

        if (image2.gameObject.activeSelf == true)
        {
            image2.gameObject.SetActive(false);
        }
        else
        {
            image2.gameObject.SetActive(true); 
        } */

        if (image1.gameObject.activeSelf == true)
        {
            image1.gameObject.SetActive(false);
            image2.gameObject.SetActive(true);
        }
        else
        {
            image1.gameObject.SetActive(true);
            image2.gameObject.SetActive(false);
        }


    }

    public void SpriteSwappingCool()
    {
        Debug.Log("Wow he changed");
        if(image2.sprite == originalSprite)
        {
            image2.sprite = swappedspriteBright;
        }
        else if(image2.sprite == swappedspriteBright)
        {
            image2.sprite = originalSprite;
        }
        
    }
}
