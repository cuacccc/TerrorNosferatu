using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosPlayer : MonoBehaviour
{

    public int vidaPlayer;


    // Update is called once per frame
    void Update()
    {
        if (vidaPlayer <= 0)
        {
            Debug.Log("Has muerto");
        }

    }
}
