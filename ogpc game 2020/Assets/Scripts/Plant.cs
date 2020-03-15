using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public Vector3 Starting;
    public int Tall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Iterations()
    {
        Tall = Tall + 1;
        Debug.Log(Tall);
        
    }

}
