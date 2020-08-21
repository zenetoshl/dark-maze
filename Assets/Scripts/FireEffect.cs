using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class FireEffect : MonoBehaviour
{

    public Light2D light2d;
    // Update is called once per frame
    void FixedUpdate()
    {
        light2d.pointLightOuterRadius = 5.5f + (Mathf.Cos(Time.time));
    }
}
