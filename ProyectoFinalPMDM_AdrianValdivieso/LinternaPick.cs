using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Clase que se encarga de reproducir el comportamiento al recoger la linterna
 */
public class LinternaPick : MonoBehaviour
{
    public GameObject Linterna;
    public AudioClip pickUpSound; // El sonido que se reproducirá al recoger la linterna
    private AudioSource audioSource;

    /**
     * Pre:---
     * Post: metodo principal en el cual le damos el valor del sonido a reproducir.
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
     * Post: metodo que reproduce el sonido en cuanto el jugador entra en contacto con el objeto.
     */
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Linterna.SetActive(true);
            Linterna.GetComponent<Linterna>().linternaEnMano = true;
            // Reproducir el sonido de recogida de la linterna
            if (pickUpSound != null)
            {
                audioSource.clip = pickUpSound;
                audioSource.Play();
            }
            // Invocar el método para destruir este GameObject después de 1 segundo
            Invoke("DestroyGameObject", 1f);
        }
    }

    /**
     * Pre:---
     * Post: método para destruir el GameObject
     */
    private void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}