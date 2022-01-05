using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad_13 : MonoBehaviour
{
    //    Napravite na sceni lika koji se krece sa W, A, S, D.
    //Nije bitna perspektiva niti način kretanja.
    //Bitno je da se na tipku "Space" spremi njegova pozicija i
    //sa ponovnim pokretanjem igre on krene od te pozicije.
    //Malo postavite neke oblike po sceni da vam bude lakše
    //prepoznati jel se spremilo ili nije.

    private void Start()
    {
        transform.position = new Vector3(PlayerPrefs.GetFloat("posX"), PlayerPrefs.GetFloat("posY"), PlayerPrefs.GetFloat("posZ"));
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            SavePosition();
        }
    }

    void SavePosition()
    {
        PlayerPrefs.SetFloat("posX", transform.position.x);
        PlayerPrefs.SetFloat("posY", transform.position.y);
        PlayerPrefs.SetFloat("posZ", transform.position.z);
    }
}
