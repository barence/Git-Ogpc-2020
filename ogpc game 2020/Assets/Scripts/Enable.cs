using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable : MonoBehaviour
{
    public bool Gone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
                Gone = !Gone;
        }
        if (Gone == (false))
        {
            gameObject.GetComponent < BoxCollider2D >().enabled = false;
            gameObject.GetComponent < SpriteRenderer >().sprite. ;
        }
        if (Gone == (true))
        {
            gameObject.GetComponent < BoxCollider2D >().enabled = true;
            gameObject.GetComponent < SpriteRenderer >().sprite. ;
        }
    }
}
