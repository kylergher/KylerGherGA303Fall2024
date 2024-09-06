using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypePracticeMath : MonoBehaviour
{

        //ADDITION (int)
        public int AdditionTotal = 0;
        public int Addition1 = 5;
        public int Addition2 = 8;
        
        //SUBTRACTION (long)
        public long Subtration1 = 2350;
        public long Subtraction2 = 7695;
        public long SubtractionTotal = 0;

        //MULTIPLICATION (float)
        public float Multiplication1 = 4f;
        public float Multiplication2 = 2.32f;
        public float MultiplicatonTotal = 1f;

        //DIVISION (double)
        public double Division1 = 5.1;
        public double Division2 = 5.94257;
        public double DivisionTotal = 30.307107;
    // Start is called before the first frame update
    void Start()
    {
        Addition();

        Subtraction();

        Multiplication();

        Division();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //FUNCTION FOR ALL EQUATIONS
    void Addition()
    {
        Debug.Log("The first number in the equation is: " + AdditionTotal);
        AdditionTotal = AdditionTotal + Addition1;
        //^This is adding 0+5
        Debug.Log("5 + 0 = " + Addition1);
        AdditionTotal = AdditionTotal + Addition2;
        Debug.Log("5 + 8 = " + AdditionTotal);
        Debug.Log("Our final total is: " + AdditionTotal);

    }

    void Subtraction()
    {
        Debug.Log("The first number in the equation is: " + SubtractionTotal);
        SubtractionTotal = SubtractionTotal - Subtration1;
        Debug.Log("0 - 2350: " + SubtractionTotal);
        SubtractionTotal = SubtractionTotal - Subtraction2;
        Debug.Log("-2350 - 7695: " + SubtractionTotal);
        Debug.Log("Our final total is: " + SubtractionTotal);
    }

    void Multiplication()
    {
        Debug.Log("The first number in the equation is: " + MultiplicatonTotal);
        MultiplicatonTotal = MultiplicatonTotal*Multiplication1;
        Debug.Log("1 x 4 = " + MultiplicatonTotal);
        MultiplicatonTotal = MultiplicatonTotal*Multiplication2;
        Debug.Log("4 x 2.32 = " + MultiplicatonTotal);
        Debug.Log("The final total is: " + MultiplicatonTotal);
    }

    void Division()
    {
        Debug.Log("Our first number in the equation is: " + DivisionTotal);
        DivisionTotal = DivisionTotal/Division1;
        Debug.Log("30.307107 / 5.1 = " + DivisionTotal);
        Debug.Log("Our final total is: " + DivisionTotal);
    }
}
