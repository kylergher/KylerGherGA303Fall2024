using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChange : MonoBehaviour
{
    public Light Spotlight;
    public Color Crayon;
    public Color Somethingelse;
    public Color Wowsocool;

    // Start is called before the first frame update
    void Start()
    {
        Spotlight.color = Crayon;
    }

    // Update is called once per frame
    void Update()
    {
      
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Button is being pressed");

            if (Spotlight.color == Crayon)
            {
                Spotlight.color = Somethingelse;
            }
            else if (Spotlight.color == Somethingelse)
            {
                Spotlight.color = Wowsocool;
            }
            else if(Spotlight.color == Wowsocool)
            {
                Spotlight.color = Crayon;
            }
        }
        
    }
    public void Yelling()
    {
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAA");
    }
}
