using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour;
public class AnotherClass
{
    public int apples;
    public int bananas;


    private int stapler;
        private int stellotapep;
    public void FruitMachine(int a, int b)
    // Start is called before the first frame update
        public int alpha = 5;


    private int beta = 0;
    private int gamma = 5;


    private AnotherClass myOtherClass;


    void Start()
    {
        alpha = 29;

        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }

    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
        private void OfficeSort(int a, int b)
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total: " + answer);
    }
}
