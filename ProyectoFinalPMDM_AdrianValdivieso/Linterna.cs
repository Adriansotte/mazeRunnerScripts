using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Clase que determina el comportamiento de la linterna y el alumbramiento de la misma
 */
public class Linterna : MonoBehaviour
{
    public Light luzLinterna;
    public bool activLight;
    public bool linternaEnMano;
    public AudioClip encenderSound;
    public AudioClip apagarSound;
    private AudioSource audioSource;

    /**
     * Pre:---
     * Post: metodo en el cual se le da valor al audio cuando se apaga o se enciende la linterna
     */
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    /**
     * Pre:---
     * Post: metodo el cual comprueba si la linterna se esta encendiendo o apagando y reproduce el sonido. 
     */
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && linternaEnMano)
        {
            activLight = !activLight;

            if (activLight)
            {
                luzLinterna.enabled = true;
                // Reproducir el sonido de encendido
                if (encenderSound != null)
                {
                    audioSource.clip = encenderSound;
                    audioSource.Play();
                }
            }
            else
            {
                luzLinterna.enabled = false;
                // Reproducir el sonido de apagado
                if (apagarSound != null)
                {
                    audioSource.clip = apagarSound;
                    audioSource.Play();
                }
            }
        }
    }
}
