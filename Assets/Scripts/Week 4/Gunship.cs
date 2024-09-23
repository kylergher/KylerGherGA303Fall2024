using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunship : MonoBehaviour
{
    public List<NewCannon> canonsgoboom = new List<NewCannon>();
    public int Currentlyselectedcanon = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(canonsgoboom.Count);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            FireCurrentlySelectedCannon();
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            DecreaseCurrentlySelectedCannonAmount();
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            IncreaseCurrentlySelectedCannonAmount();
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            FireTheThangs();
        }
        
    }

    public void FireCurrentlySelectedCannon()
    {
        canonsgoboom[Currentlyselectedcanon].FireCannon();
    }

    public void DecreaseCurrentlySelectedCannonAmount()
    {
        Currentlyselectedcanon--;
    }

    public void IncreaseCurrentlySelectedCannonAmount()
    {
        Currentlyselectedcanon++;
    }

    public void FireTheThangs()
    {

    }
}
