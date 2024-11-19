using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzVelaPlato : MonoBehaviour
{
    public Light LuzVela;
    public bool ActiveLight;
    public bool EncendedorEnMano;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && EncendedorEnMano == true)
        {
            ActiveLight = !ActiveLight;

            if (ActiveLight == true)
            {
                LuzVela.enabled = true;
            }

            if (ActiveLight == false)
            {
                LuzVela.enabled = false;
            }
        }

    }
}
