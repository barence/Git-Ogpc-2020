using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomize : MonoBehaviour
{
    public GameObject OrangeHead;
    public GameObject YellowHead;
    public GameObject RedHead;
    public GameObject GreenTorso;
    public GameObject AquablueTorso;
    public GameObject SkyblueTorso;
    public GameObject BlueLegs;
    public GameObject PurpleLegs;
    public GameObject PinkLegs;
    public void random ()
    {
        int number = Random.Range(1, 4);

         if (number == 1)
         {
           
            OrangeHead.SetActive(true);
            YellowHead.SetActive(false);
            RedHead.SetActive(false);
        }
        if (number == 2)
        {
          
            OrangeHead.SetActive(false);
            YellowHead.SetActive(true);
            RedHead.SetActive(false);
        }
        if (number == 3)
        {
           
            OrangeHead.SetActive(false);
            YellowHead.SetActive(false);
            RedHead.SetActive(true);
        }
        int number1 = Random.Range(1, 4);

        if (number1 == 1)
        {

            GreenTorso.SetActive(true);
            AquablueTorso.SetActive(false);
            SkyblueTorso.SetActive(false);
        }
        if (number1 == 2)
        {

            GreenTorso.SetActive(false);
            AquablueTorso.SetActive(true);
            SkyblueTorso.SetActive(false);
        }
        if (number1 == 3)
        {

            GreenTorso.SetActive(false);
            AquablueTorso.SetActive(false);
            SkyblueTorso.SetActive(true);
        }
        int number2 = Random.Range(1, 3);

        if (number2 == 1)
        {

            BlueLegs.SetActive(true);
            PurpleLegs.SetActive(false);
            PinkLegs.SetActive(false);
        }
        if (number2 == 2)
        {

            BlueLegs.SetActive(false);
            PurpleLegs.SetActive(true);
            PinkLegs.SetActive(false);
        }
        if (number2 == 3)
        {

            BlueLegs.SetActive(false);
            PurpleLegs.SetActive(false);
            PinkLegs.SetActive(true);
        }
    }
 
}
