using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class FinshGame : MonoBehaviour
{
    public GameObject sliderText;
    public int levelOn = 1;
    public int Value;
    public Slider progression;
    public Text percent;
    public TextMeshProUGUI percentOnCup;
    public int x;
    public float p;
    public float c;
    public GameObject finsh;
    public Animator transition;
    public float transistionTime = 1f;

    void Start()
    {
        p = 0;
        c = 100;
        levelOn = SceneManager.GetActiveScene().buildIndex + 1;
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
            LoadNextlevel();
            finsh.SetActive(false);
            sliderText.SetActive(false);
            if (levelOn > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", levelOn);
            }
        }
    
        c = 100 - p;
        p = x / 3;
        progression.value = p;
        percent.text = p.ToString() + "%";
        percentOnCup.text = c.ToString();
    }

    public void LoadNextlevel()
    {
        StartCoroutine(Loadlevel(SceneManager.GetActiveScene().buildIndex + 1));

    }

    IEnumerator Loadlevel(int Levelindex)
    {

        transition.SetTrigger("Start");

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(Levelindex);

    }
}