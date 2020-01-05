using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Reset : MonoBehaviour
{
     public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Restart1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
         public void Restart2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
