using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private bool Invincibility;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Las    er") && Invincibility == false)
        {
            transform.position = new Vector3(4, 2, -0.1f);
        }
    }
    public void SetInvincibility(bool invincibility)
    {
        Debug.Log(invincibility);
        Invincibility = invincibility;
    }
}   

