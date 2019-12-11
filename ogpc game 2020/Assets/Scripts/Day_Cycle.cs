using UnityEngine;
using System.Collections;

public class Day_Cycle : MonoBehaviour
{

    public UnityEngine.Experimental.Rendering.LWRP.Light2D light2D;

    void Update()
    {
        light2D.intensity = Mathf.Sin(Time.timeSinceLevelLoad / 60) + 0.5f;
    }
}