using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypePracticeWORD : MonoBehaviour
{
       public char LetterOne = 'r';
        public char LetterTwo = 'o';
        public char LetterThree = 'm';
        public char LetterFour = 'e';
        public char LetterFive = 'n';
        public char LetterSix = 't';
        public char LetterSeven = 'g';
        public char LetterEight = 'u';
    // Start is called before the first frame update
    void Start()
    {
       Romeo();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Romeo()
    {
      

        Debug.Log("My Cat Is Named: " + LetterOne + LetterTwo + LetterThree + LetterFour + LetterTwo + " " + LetterThree +LetterTwo + LetterFive + LetterSix + LetterFour + LetterSeven + LetterEight + LetterFour);

    }
}
