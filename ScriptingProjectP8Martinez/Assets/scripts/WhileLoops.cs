using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    // Start is called before the first frame update
    int cupsInTheSink = 4;
    void Start()
    {
        while(cupsInTheSink > 0)
        {
         
    // Update is called once per frame
    void Update()
        {
                Debug.Log("I've washed a cup!");
                cupsInTheSink--;
        }
    }
}
