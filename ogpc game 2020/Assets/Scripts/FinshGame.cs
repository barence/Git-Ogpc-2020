using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinshGame : MonoBehaviour
{
    public int X;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ( X == 1000)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("liqud"))
        {
            X = X + 1;
        }
    }

}
