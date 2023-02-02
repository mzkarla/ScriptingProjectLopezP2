using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{ /*
  // In this case, result = 4
    float result = Mathf.Lerp (3f. 5f, 0.5f);
    //The Mathf.Lerp takes 3 float parameters, one representing the value to interpolate from,another representing the value to interpolate to, and a final representing how far to interpolate
    // Start is called before the first frame update
    void Start()
    {
        Vector3 from = new Vector3(1f, 2f, 3f);
        Vector3 to = new Vector3(5f, 6f, 7f);

        // Here result = (4, 5, 6)
        Vector3 result = Vector3.Lerp(from, to, 0.75f);
    }

    // Update is called once per frame
    void Update()
    {
        light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f);
        //used to smooth a value over time, the lights intensity rate of its change will slow as it approaches its target, this will happen over a course of frames
       
    light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
        //The change of to intensity would happen per second instead of per fram
    }
    */
}