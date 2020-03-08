using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AchievementDisplay : MonoBehaviour
{
    public bool Complete = false;
    public int Type;
    public Achievement achievement;
    public TextMeshProUGUI TitleText;
    public TextMeshProUGUI DescriptionText;
    public TextMeshProUGUI Difficultytext;
    public Image ArtworkImage;
    public Slider Progressbarslider;


    // Start is called before the first frame update
    void Start()
    {
        ArtworkImage.sprite = achievement.Image;
        TitleText.text = achievement.Title;
        DescriptionText.text = achievement.Description;
        Difficultytext.text = achievement.difficutly;
        Progressbarslider = achievement.Progressbar;
    }

    // Update is called once per frame
    void Update()
    {
        if (Type == 1)
        {
            Complete = true;
        }
        if (Type == 2)
        {
            Complete = true;
        }
    }
}
