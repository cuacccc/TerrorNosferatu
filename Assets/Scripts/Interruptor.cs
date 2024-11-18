using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interruptor : MonoBehaviour
{
    public GameObject LuzObjeto;
    public bool Luz;
    private bool ActiveLight;

    public void Encendido() 
    {
        ActiveLight = !ActiveLight;

        if (ActiveLight == true)
        {
            LuzObjeto.SetActive(true);

        }

        if (ActiveLight == false)
        {
            LuzObjeto.SetActive(false);
        }
    }
}