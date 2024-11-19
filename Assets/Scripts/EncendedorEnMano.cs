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
            NotificationsManager.Instance.ShowNotification(
                "¿Un encendedor? ¿Que se supone que haga con esto? <i>(Presiona E para utilizarlo).</i>",
                5f
            );
        }
    }
}
