using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCaida : MonoBehaviour
{
    AudioSource FuenteAudio;

    // Start is called before the first frame update
    void Start()
    {
        FuenteAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        FuenteAudio.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        FuenteAudio.Stop();
        
    }
}

