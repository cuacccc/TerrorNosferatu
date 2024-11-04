using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DatosPlayer : MonoBehaviour
{

    public int vidaPlayer;
    public Slider vidaVisual;
    
    


    // Update is called once per frame
        private void Update()


    {
        vidaVisual.GetComponent<Slider>().value = vidaPlayer;

        if (vidaPlayer <= 0)
        {
            SceneManager.LoadScene("PantallaDerrota");

        }

                    

    }

    

}
