using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    int numEneimes = 3;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numEneimes; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }
}