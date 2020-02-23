using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flow : MonoBehaviour
{

    public GameObject Liquadprefab = null;
    bool canCount = false;
    public int C;
    float X;
    public float y;
    public float b;

    void Start()
    {

    }
    void FixedUpdate()
    {
        if (canCount == true)
        {
            X = Random.Range(y, b);
            
            Instantiate(Liquadprefab, new Vector3(X, 3.265f, -1), Quaternion.identity);
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