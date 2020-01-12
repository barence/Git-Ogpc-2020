using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{
    void Update()
    {
       
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.CompareTag("liqud"))
       {
            Destroy(collision.gameObject);
       }
    }
}
