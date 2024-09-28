using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;

public class Text : MonoBehaviour
{
    public string[] lines;
    public float textSpeed;
    public GameObject setPiece;


    // Start is called before the first frame update
    void Start()
    {
        if (setPiece.CompareTag("Door"))
        {
            setPiece.SetActive(true);
        }

        if (setPiece.CompareTag("Suitcase"))
        {
            setPiece.SetActive(false);
        }

        if (setPiece.CompareTag("Desk"))
        {
            setPiece.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
