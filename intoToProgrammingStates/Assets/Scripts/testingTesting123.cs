using UnityEngine;
using UnityEditor;
using System;
using System.Linq;
using Unity.VisualScripting;

public class testingTesting123 : MonoBehaviour
{

    public int whatever = 0;
    public int throwaway = 0;
    bool testThreshold = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Testingtesting123");
    }

    // Update is called once per frame
    void Update()
    {
        if (testThreshold == true)
        {
            
            
            throwaway++;

            if (new[] {1}.Contains(throwaway%100))
            {
                whatever++;
            }

            if (whatever == 7)
            {
                Debug.Log("whatever is equal to seven");

            }
        }
    }

    public void ChickenTenders()
    {
        if (testThreshold == false)
        {
            testThreshold = true;
            return;
        }

        if (testThreshold == true)
        {
            testThreshold = false;
            return;
        }
    }

}
