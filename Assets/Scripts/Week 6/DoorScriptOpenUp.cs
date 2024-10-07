using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScriptOpenUp : MonoBehaviour
{
    public GameObject Door;
    public Transform playerLookie;
    public PlayerScriptMC itsTheGuy;

    public KeyColor doorColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
            RaycastHit hit;

            if (Physics.Raycast(playerLookie.position, playerLookie.forward, out hit))
            {
                Debug.Log(hit.collider.gameObject.name);

                if ((Input.GetKeyDown(KeyCode.E)) && itsTheGuy.numBronzeKeys >= 1 && doorColor == KeyColor.Bronze)
                {
                    Debug.Log("You can now enter");
                    Move();
                }

                if ((Input.GetKeyDown(KeyCode.E)) && itsTheGuy.numSilverKeys >= 1 && doorColor == KeyColor.Silver)
                {
                    Debug.Log("Go ahead and go in!");
                    Move();
                }

                if ((Input.GetKeyDown(KeyCode.E)) &&itsTheGuy.numGoldKeys >= 1 && doorColor == KeyColor.Gold)
                {
                    Debug.Log("oh boy oh boy, you can go inside now!!");
                    Move();
                }

            }
        
    }

    public void Move()
    {
        if (Door.gameObject.transform.position.y <= 4)
        {
            Door.gameObject.transform.position += Vector3.up * 7;
        }
    }
}
