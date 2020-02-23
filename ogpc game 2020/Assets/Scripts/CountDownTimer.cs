using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{

    public float timestart;
    public GameObject highscore;

    void Start()
    {
    }
    void Update()
    {
        timestart += Time.deltaTime;
        if (timestart >= 1.3f)
        {
            highscore.SetActive(true);

        }
    }
}
