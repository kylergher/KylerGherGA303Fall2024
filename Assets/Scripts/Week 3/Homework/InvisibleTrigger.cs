using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleTrigger : MonoBehaviour
{
    public GameObject WOW;

    // Start is called before the first frame update
    void Start()
    {
        WOW.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider phase)
    {
        if(phase.gameObject.CompareTag("IAmABall") == true)
        {
            WOW.SetActive(true);

            phase.gameObject.tag = "DoublePower";
        }
    }
}
