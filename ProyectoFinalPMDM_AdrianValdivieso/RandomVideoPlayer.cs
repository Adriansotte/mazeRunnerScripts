using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

/**
 * Clase en la cual se genera el video de la muerte del jugador
 */
public class RandomVideoPlayer : MonoBehaviour
{
    public VideoClip[] videos;

    /**
     * Pre:---
     * Post: Metodo en el cual se define el video que se va a reproducir 
     */
    void Start()
    {
        // Seleccionar aleatoriamente un �ndice de v�deo
        int randomIndex = Random.Range(0, videos.Length);

        // Reproducir el v�deo seleccionado
        GetComponent<VideoPlayer>().clip = videos[randomIndex];
        GetComponent<VideoPlayer>().Play();
        GetComponent<VideoPlayer>().loopPointReached += OnVideoFinished;
    }

    /*
     * Pre:---
     * Post: M�todo que se llama cuando el v�deo ha terminado de reproducirse
     */
    void OnVideoFinished(UnityEngine.Video.VideoPlayer vp)
    {
        // Cargar la escena del men� principal
        SceneManager.LoadScene("MainMenu");
    }
}
