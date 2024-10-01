using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToRayCast : MonoBehaviour
{
    public Transform CameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;

            if (Physics.Raycast(CameraTransform.position, CameraTransform.forward, out hit))
            {
                Debug.Log(hit.collider.gameObject.name);

                if(hit.collider.tag == "JeffTag")
                {
                    Debug.Log("I HIT JEFF OH FUCK, NOOOOOOOOOO");
                    hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                }

                if(hit.collider.tag == "HasKey")
                {
                    Debug.Log("cubert...... no");
                    hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                }

                if(hit.collider.tag == "BallMan")
                {
                    Debug.Log("Yeah we've been called in to make this guy blue");
                    hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
                }

            }
        }
    }
}
