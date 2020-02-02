using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Off : MonoBehaviour
{
    public bool On;

    void Start()
    {
        On = true;
    }

    void Update()
    { 
    }


    void OnMouseDown()
    {
        On = !On;
        if (On == true)
        {
            GetComponent<PointEffector2D>().forceMagnitude = (-0.15f);
        }
        if (On == false)
        {
            GetComponent<PointEffector2D>().forceMagnitude = (0);
        }
    }
}
