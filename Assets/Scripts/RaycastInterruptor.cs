using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastInterruptor : MonoBehaviour
{
    public int Rango;
        
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Rango))
        {
            if(hit.collider.GetComponent<Interruptor>() == true)
            {
                if (Input.GetKeyDown(KeyCode.I))
                {
                    if (hit.collider.GetComponent<Interruptor>().Luz == true)
                    {
                        hit.collider.GetComponent<Interruptor>().Encendido();
                    }
                }

            }
        }    

    }

    // mostrar rayo Raycast
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * Rango);

    }
}
