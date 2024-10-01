using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class DialogueLists : MonoBehaviour
{

    public List<string> dialogue = new List<string>();
    public TextMeshProUGUI dialogueBox;
    public int dialogueIndex = 0;


    void Start()
    {
        dialogueBox.text = dialogue[dialogueIndex];
        //we're changing the public variable by having '='
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Player Pressed Space");

            if (dialogueIndex + 1 >= dialogue.Count) //if we're about to go out of range, just tell us
            {
                dialogueBox.gameObject.SetActive(false);
                Debug.Log("dialogueIndex is about to go out of range. Ending update now");
                //return; //if its too much, we'll just never use the rest of the code
            }

            else //else, just run the rest of the code
            {
                dialogueIndex++;
                Debug.Log("It's Gone Up, boys!!!");

                if (dialogueIndex < dialogue.Count)
                {
                    dialogueBox.text = dialogue[dialogueIndex];//we're now changing the text to the next element
                    Debug.Log("We're now changng the next to the next element, sir yes sir!");
                }
            }

           
            
        }

    }
}
