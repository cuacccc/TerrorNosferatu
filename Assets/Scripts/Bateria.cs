using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bateria : MonoBehaviour
{
    public GameObject linterna;
    public float bateria;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            linterna.GetComponent<Linterna>().cantBateria += bateria;
            Destroy(gameObject);
        }
    }
}
