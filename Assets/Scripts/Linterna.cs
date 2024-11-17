using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Linterna : MonoBehaviour
{
    public Light LuzLinterna;
    public bool ActiveLight;
    public bool LinternaEnMano;
    public float cantBateria = 100;
    public float perdidaBateria = 0.5f;

    //[Header("Visuales")]
    //public Image pila1;
    //public Image pila2;
    //public Image pila3;
    //public Image pila4;
    //public Sprite pilaVacia;
    //public Sprite pilaLlena;
    //public Text porcentaje;

    void Update()
    {
    //    cantBateria = Mathf.Clamp(cantBateria, 0, 100);
    //    int valorBaateria = (int)cantBateria;
     //   porcentaje.text = valorBaateria.ToString() + "%";
           
   
        if (Input.GetKeyDown(KeyCode.L) && LinternaEnMano == true)
        {
            ActiveLight = !ActiveLight;

            if (ActiveLight == true) 
            {
                LuzLinterna.enabled = true;
            }

            if (ActiveLight == false)
            {
                LuzLinterna.enabled=false;
            }
        }
        
        //if (ActiveLight == true && cantBateria > 0)
        //{
        //    cantBateria -= perdidaBateria * Time.deltaTime;
        //}

        //if(cantBateria == 0)
        //{
        //    LuzLinterna.intensity = 0f;
        //    pila1.sprite = pilaVacia;
        //}


        //if (cantBateria > 0 && cantBateria <= 25)
        //{
        //    LuzLinterna.intensity = 1f;
        //    pila1.sprite = pilaLlena;
        //    pila2.sprite = pilaVacia;

        //}

        //if (cantBateria > 25 && cantBateria <= 50)
        //{
        //    LuzLinterna.intensity = 1.5f;
        //    pila2.sprite = pilaLlena;
    //        pila3.sprite = pilaVacia;
      //  }

        //if (cantBateria > 50 && cantBateria <= 75)
        //{
          //  LuzLinterna.intensity = 2f;
            //pila3.sprite = pilaLlena;
        //    pila4.sprite = pilaVacia;
       // }

        //if (cantBateria > 75 && cantBateria <= 100)
        //{
          //  LuzLinterna.intensity = 2.5f;
            //pila4.sprite = pilaLlena;
            
        //}
    }

}