using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncendedorEnMano : MonoBehaviour
{
    public GameObject Encendedor;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Encendedor.SetActive(true);
            Encendedor.GetComponent<Encendedor>().EncendedorEnMano = true;
            Destroy(gameObject);
        }
    }
}
