using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Object : MonoBehaviour
{
    public float rSpeed = 50.0f;
    public GameObject Rotating_Object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDrag()
    {
        Rotating_Object.transform.Rotate(Vector3.forward * rSpeed * Time.deltaTime);
    }

}
