using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Zbrojite x koji je 17.2 i y koji je 12.32. Rje�enje napi�ite u javnoj varijabli �Javna�
public class Vjezbe2_1 : MonoBehaviour
{
    public float x = 17.2f; //Rezervirana je varijabla x
    public float y = 12.32f; //Rezervirana je varijabla y
    public float javna; //Rezervirana je varijabla javna
    private void Start()
    {
        javna = x + y; //U start procesu vr�imo matemati�ku funkciju zbrajanja �lanova x i y u javnu varijablu
    }
}
