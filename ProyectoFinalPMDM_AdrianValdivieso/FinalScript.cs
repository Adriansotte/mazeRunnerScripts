using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Clase la cual se encarga de cambiar la escena final del juego.
 */
public class FinalScript : MonoBehaviour
{
    /**
     * Pre:---
     * Post: Metodo principal en el cual se cambia a la escena final.
     */
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("FinalScene");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
