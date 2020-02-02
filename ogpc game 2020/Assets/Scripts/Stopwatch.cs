using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    public string time = "time highscore";
    public static float timestart;
    public Text textBox;

    void Start()
    {
        textBox.text = timestart.ToString("F2");
}
    void Update()
    { 
        timestart += Time.deltaTime;
        textBox.text = timestart.ToString("F2");
    }
}
