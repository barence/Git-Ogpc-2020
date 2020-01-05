using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flow : MonoBehaviour
{

    public GameObject Liquadprefab = null;
    bool canCount = false;
    public int C;
    float X;

    void Start()
    {
        C = 0;
    }
    void FixedUpdate()
    {
        if (canCount == true)
        {
            X = Random.Range(-4.2f, -4.0f);
            
            Instantiate(Liquadprefab, new Vector3(X, 3.64f, -1), Quaternion.identity);
            C = C + 1;
        }
    }
    public void Play()
    {
        canCount = true;
    }   
    public void Pause()
    {
        canCount = false;
    }

    void Update()
    {
        if (C == 900)
        {
            canCount = false;
        }
    }
}