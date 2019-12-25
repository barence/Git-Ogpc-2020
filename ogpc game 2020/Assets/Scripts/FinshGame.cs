using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class FinshGame : MonoBehaviour
{
    public Slider progression;
    public Text percent;
    public int x;
    public float p;
    void Start()
    {
        p = 0;

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("liqud"))
        {
            x = x + 1;
        }
    }
    void Update()
    {
        if (x == 300)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        p = x / 3;
        progression.value = p;
        percent.text = p.ToString() + "%";
    }
}
