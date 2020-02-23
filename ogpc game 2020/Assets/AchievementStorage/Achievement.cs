using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewAchievement", menuName = "Achievement")]
public class Achievement : ScriptableObject
{
    public string Title;
    public string Description;
    public Sprite Image;
    public Slider Progressbar;
    public string difficutly;
}
