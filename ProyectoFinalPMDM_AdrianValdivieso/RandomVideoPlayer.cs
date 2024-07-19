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
        // Seleccionar aleatoriamente un índice de vídeo
        int randomIndex = Random.Range(0, videos.Length);

        // Reproducir el vídeo seleccionado
        GetComponent<VideoPlayer>().clip = videos[randomIndex];
        GetComponent<VideoPlayer>().Play();
        GetComponent<VideoPlayer>().loopPointReached += OnVideoFinished;
    }

    /*
     * Pre:---
     * Post: Método que se llama cuando el vídeo ha terminado de reproducirse
     */
    void OnVideoFinished(UnityEngine.Video.VideoPlayer vp)
    {
        // Cargar la escena del menú principal
        SceneManager.LoadScene("MainMenu");
    }
}
