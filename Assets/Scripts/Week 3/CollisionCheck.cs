using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void OnCollisionEnter(Collision OtherObject)
    { 
        Debug.Log("IVE BEEN HIT");
        
        if (OtherObject.collider.gameObject.CompareTag("JeffTag") == true)
        {
            Debug.Log("NOOOOOOOO!! CURSE YOU Jeff THE GameObject!!!!!!");
            Destroy(this.gameObject);
        }

       
       
    }
    //public void OnCollisionExit()
}
   

