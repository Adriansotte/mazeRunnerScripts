using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Clase en la cual se gestiona el cambio de pantalla entre
 */
public class NuevaPartidaScript : MonoBehaviour
{
    public void changeScene(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}
