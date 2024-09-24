using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScottPilgrim : MonoBehaviour
{

    public string myName = "Scott Pilgrim";
    public int age = 25;
    public string profession = "Comic Book Writer";
    public string favoriteMovie = "Scott Pilgrim vs The World";
    public int elleFriendshipPoints = 0;
    public int santaClausFriendshipPoints = 0;
    public int colonelSandersFriendshipPoints = 0;

    public Person elle;
    public Person santaClaus;
    public Person colonelSanders;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IntroduceSelf()
    {
        Debug.Log("We will introduce ourselves using the myName: " + myName + " - variable");
    }

    public void AskFavoriteMovie()
    {
        Debug.Log("Dude my favorite movie is something");
    }

    public void AskEmbarrassingMoment()
    {
        Debug.Log("if we have 5 friendship points we can ask about embarrassing moment");
    }

    public void AskSeeCoolSkill()
    {
        Debug.Log("We're asking to see you do a rad backflip");
    }
}
