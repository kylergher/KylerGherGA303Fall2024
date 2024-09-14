using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IveBeenHit : MonoBehaviour
{
    //this script should be applied to any object that will be hit by the ball 
    public GameObject Magic;
    public GameObject MagicMissile;

    // Start is called before the first frame update
    void Start()
    {
        Magic.SetActive(false);
        MagicMissile.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision ballman)
    {
        if (ballman.collider.gameObject.CompareTag("IAmABall") == true)
        {
            Magic.SetActive(true);
        }
        else if (ballman.collider.gameObject.CompareTag("DoublePower") == true)
        {
            Magic.SetActive(true);
            MagicMissile.SetActive(true);
        }
    }
}
