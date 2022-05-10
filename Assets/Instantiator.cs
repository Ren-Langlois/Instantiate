using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClon;
    public int NumeroDeCubos;
    

    public void CloneObjetc()
    {
        int contador = 0;
        while (contador < NumeroDeCubos )
        {
            Instantiate(objectToClon);
            contador++;
        }
    }
}
