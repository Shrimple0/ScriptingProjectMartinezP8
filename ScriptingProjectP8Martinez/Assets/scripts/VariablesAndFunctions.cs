using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    //Create a variable of type integer
    int MyInt = 7;


    // Start is called before the first frame update
    void Start()
    {
        //I am going to run MyInt thru my function to multiply by 2
        MyInt = MultiplyByTwo(MyInt);

        //I'm going to print the results to the console
        Debug.Log(MyInt);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    //Creating a function that takes a int parameter and multiplies it by 2
    int MultiplyByTwo(int number)
    {
        //Creating a variable to store my results
        int results;
        //multiplying past parameter by 2
        results = number * 2;

        //Returning the results
        return results;
    }
}
