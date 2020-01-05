using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public Rigidbody2D rb;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;       
    }
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3 (0, -3, 0);
    }
    void OnMouseDrag()
    {
        transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.nearClipPlane));
    }
    // void OnMouseUp()
    // {
    //    print("AO");
    // }
}
