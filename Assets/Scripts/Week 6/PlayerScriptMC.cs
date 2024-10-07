using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerScriptMC : MonoBehaviour
{
  

    public int numBronzeKeys = 0;
    public int numSilverKeys = 0;
    public int numGoldKeys = 0;
    public Transform CameraTransform;
    public TextMeshProUGUI textBoxE;



    // Start is called before the first frame update
    void Start()
    {
        textBoxE.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(CameraTransform.position, CameraTransform.forward, out hit))
        {
            Debug.Log(hit.collider.gameObject.name);

            if (hit.collider.tag == "BronzeDoor")
            {
                Debug.Log("You Need A Bronze Key");
                textBoxE.gameObject.SetActive(true);
            }

            if (hit.collider.tag == "SilverDoor")
            {
                Debug.Log("You Need A Silver Key");
                textBoxE.gameObject.SetActive(true);
            }

            if (hit.collider.tag == "GoldDoor")
            {
                Debug.Log("You Need A Gold Key");
                textBoxE.gameObject.SetActive(true);
            }
        }
        
    }

    public void addKey(KeyColor shinyLevel)
    {
        if (shinyLevel == KeyColor.Bronze)
        {
            Debug.Log("You picked up a bronze key!");
            numBronzeKeys++;
        }

        if (shinyLevel == KeyColor.Silver)
        {
            Debug.Log("You picked up a silver key!");
            numSilverKeys++;
        }

        if (shinyLevel == KeyColor.Gold)
        {
            Debug.Log("You picked up a gold key!");
            numGoldKeys++;
        }


    }
}
