using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Encendedor : MonoBehaviour
{
    public Light LuzEncendedor;
    public bool activeLight;
    public bool EncendedorEnMano;

    // Update is called once per frame
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.E) && EncendedorEnMano == true) 
        {
            activeLight = !activeLight;

            if (activeLight == true)
            {
                LuzEncendedor.enabled = true;
            }

            if (activeLight == false)
            {
                LuzEncendedor.enabled = false;
            }

        }
    }
}
