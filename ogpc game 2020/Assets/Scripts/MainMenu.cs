using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public int num;
    public Button[] lvlButtons;
    public int LevelValue;
    public Animator transition;
    public float transistionTime = 1f;
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);
        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 2 > levelAt)
                lvlButtons[i].interactable = false;
        }
    }
    public void LoadNextlevel()
    {
        StartCoroutine(Loadlevel(SceneManager.GetActiveScene().buildIndex + num));
        LevelValue = PlayerPrefs.GetInt("Level set");
    }


    IEnumerator Loadlevel(int Levelindex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(Levelindex);
    }

    public void Restart()
    {
        PlayerPrefs.SetInt("Level set", 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
