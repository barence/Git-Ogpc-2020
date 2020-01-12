using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class FinshGame : MonoBehaviour
{
    public string key = "Level set";
    public int Value = 0;
    public Slider progression;
    public Text percent;
    public Text percentOnCup;
    public int x;
    public float p;
    public float c;
    public GameObject finsh;
    void Start()
    {
        p = 0;
        c = 100;
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
        if (c == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            if (c == 0)
            {
                finsh.SetActive(false);
                Value = PlayerPrefs.GetInt(key);
                Value = Value + 1;
                PlayerPrefs.SetInt(key, Value);
                Debug.Log(PlayerPrefs.GetInt(key));
            }
        }
        c = 100 - p;
        p = x / 3;
        progression.value = p;
        percent.text = p.ToString() + "%";
        percentOnCup.text = c.ToString();
    }
}
