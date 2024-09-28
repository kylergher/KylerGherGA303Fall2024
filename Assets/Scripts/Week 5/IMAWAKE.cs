using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

public class IMAWAKE : MonoBehaviour
{
    public float vanish = 0f;
    public float vabish = 2f;
    public GameObject textbox;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnEnable()
    {
        vanish += Time.deltaTime;
        if (vanish == 2f)
        {


            Debug.Log("k im gonna dip now, peace");
            textbox.SetActive(false);
        }
    }
}
