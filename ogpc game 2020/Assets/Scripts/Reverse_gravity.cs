using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reverse_gravity : MonoBehaviour
{
    public bool On = false;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.gravity = new Vector3(0, 6, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (On == true)
        {
            Physics2D.gravity = new Vector3(0, 6, 0);
        }
        if (On == false)
        {
            Physics2D.gravity = new Vector3(0, -6, 0);
        }

    }
    public void Gravity()
    {
        On = !On;
    }

}
