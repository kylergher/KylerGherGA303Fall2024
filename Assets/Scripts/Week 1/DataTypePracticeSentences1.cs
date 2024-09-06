using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypePracticeSentences1 : MonoBehaviour
{

    public string Sentence1;
    public string Sentence2;
    public string Sentence3;
    public string Sentence4;
    public string Sentence5;

   
    // Start is called before the first frame update
    void Start()
    {
        Sentences();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Sentences()
    {
        Debug.Log(Sentence1);
        Debug.Log(Sentence2);
        Debug.Log(Sentence3);
        Debug.Log(Sentence5);
    }
}
