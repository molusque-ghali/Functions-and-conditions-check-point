using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class additionessai : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float resultat;
        resultat = addition(6, 2);
        Debug.Log(resultat);
        resultat = division(6, 2);
        Debug.Log(resultat);
        resultat = soustraction(6, 2);
        Debug.Log(resultat);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float addition(float a, float b)
    {
        float add = a + b;
        return add;
    }
    float division(float a, float b)
    {
        float d = a / b;
        return d;
    }
    float soustraction(float a, float b)
    {
        float s = a - b;
        return s;
    }
}