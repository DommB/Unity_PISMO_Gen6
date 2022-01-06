using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zad_10 : MonoBehaviour
{
    //10.) Napravite skriptu koja učitava 3 fonta u array. Na pritisku lijeve tipke miša neka se promjeni
    //font za jedan na veću u arrayu, a na pritisku desne tipke neka se promjeni font za jedan nižu u
    //arrayu.Svaka promjena fonta je vidljiva na tekstu na sceni. Također mora biti i jedan text
    //mesh pro na sceni koji će samo brojati koliko puta je napravljena promjena fonta.

    public Font[] fonts;
    public Text textic;
    int activeFont = 0;
    int countChanges = 0;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(activeFont < fonts.Length - 1)
            {
                activeFont++;
                textic.font = fonts[activeFont];
            }
            else
            {
                activeFont = 0;
                textic.font = fonts[activeFont];
            }
            countChanges++;
            textic.text = countChanges.ToString();
        }

        if(Input.GetMouseButtonDown(1))
        {
            if(activeFont > 0)
            {
                activeFont--;
                textic.font = fonts[activeFont];
            }

            else
            {
                activeFont = fonts.Length - 1;
                textic.font = fonts[activeFont];
            }
            countChanges++;
            textic.text = countChanges.ToString();

        }
    }
}
