using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Object : MonoBehaviour
{
    public float Speed = 50.0f;
    public GameObject Moving_object;
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
        Moving_object.transform.Translate(Vector3.right * Speed * Time.deltaTime);
    }
}
