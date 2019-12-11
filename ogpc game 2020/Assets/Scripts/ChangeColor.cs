using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Renderer waterRenderer;

    [SerializeField]
    public Color waterColor = Color.white;

    void Start()
    {
            waterRenderer = GetComponent<Renderer>();
            waterRenderer.material.color = waterColor;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {

        }
    }
}
