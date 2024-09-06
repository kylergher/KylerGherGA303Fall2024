using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypePractice : MonoBehaviour
{
   
    //WHOLE NUMBERS
    public int num1; //int is 4 bytes (what is the difference between bit and byte) - int stores whole numbers from -2,147,483,648 to 2,147,483,648
    public int num2; //public or private, then datatype, then name

    public long num3; //long holds much longer nubers (like. 9 million pos and negative)

    public uint num4; //uint is still 4bytes but allows up to ~4.29 billion (POSITIVE ONLY)
    public ulong num5; //ulong is still 8bytes but allows up to ~18.4 quintillion (POSITIVE ONLY)

  
    //DECIMALS
    public float num6 = 3.14f; //float is 4 bytes (like int) but stores decimal numbers up to 6-7 digits
    public double num7 = 3.14159265; //double is 8 bytes - stores decimal numbers up to 15-17 digits - more precision

  
    //TRUE OR FALSE
    public bool isProgramingHard = true; //bool is data type that asks true/false (1 for true, 0 for false) bool is one bit only stores true/false 1/0

   
    //DATA SIZES
    //1 byte = 8 bits; 
    //1024 bytes = 1 kilobyte
    //1024 kilobytes = 1 megabyte 
    //1024 megabytes = 1 gigabytes
    //1024 gigabytes = 1 terabyte

    //300Mbps = this is not 300MBps - this is 300 megabits per second // lowercase b means bit uppercase B means byte
    //1 gigabit internet = download speed of 125megaBYTES per second MAX

   
   
    //TEXT VARIABLES
    public char Charizard = 'a';
    public char Blastoise = 'b';
    public char Venusaur = 'c';

    public string monsters = "Pokemon are cool, but " + 
    "so is undertale so yayyy i love coding wht" +
    "is vebm happening what what what hwwat hwat";


    //THESE ARE DATATYPES KINDA WE'LL GET TO IT
    public Light lightandshinging;
    public Transform transformmovingtihngs;



    // Start is called before the first frame update
    void Start() //eveyrhting in a function 
    {
        Debug.Log("The starting number for num1 is: " + num1);
        num1 = num1 + 1; //simple addition
        Debug.Log("The end number for num1 after adding 1 is: " + num1);
        
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(Charizard);

    }
}
