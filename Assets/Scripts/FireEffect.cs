using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class FireEffect : MonoBehaviour
{

    public Light2D light2d;
    public float outerRadius;
    public float cosMultiplier;
    // Update is called once per frame
    void FixedUpdate()
    {
        light2d.pointLightOuterRadius = outerRadius + (cosMultiplier * Mathf.Cos(Time.time));
    }
}
