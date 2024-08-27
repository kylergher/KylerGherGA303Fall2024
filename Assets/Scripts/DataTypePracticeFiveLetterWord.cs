using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypePracticeFiveLetterWord : MonoBehaviour
{

//i am going to write out notes to myself

    //Within public class but before void start: put the variables that the code will be referencing 
    //In this case we are creating TEXT VARIABLES 
    //Text variables are notated with "public char ___" = 'x';
    // which is a lot and its scary but i can do hard things
    //okay,,

    public char FirstLetter = 'c';
    public char SecondLetter = 'r';
    public char ThirdLetter = 'e';
    public char FourthLetter = 'a';
    public char FifthLetter = 't';
    public char SixthLetter = 'e';

    //okay so now, with those lines done, the script will have something to reference
    //now we just need to write the script

    //in this case, we need to use Debug.Log() as well as the 'simple addition' line

    // Start is called before the first frame update
    void Start() //Code executing (this is what the program will read to enact the code)
    {
        Debug.Log("The Word I Chose Was: " + FirstLetter + SecondLetter + ThirdLetter + FourthLetter + FifthLetter + ThirdLetter);


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
