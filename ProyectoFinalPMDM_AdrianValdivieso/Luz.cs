using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Clase en la cual se gestiona el parpadeo de las luces.
 */
public class Luz : MonoBehaviour
{

    public bool titila = false;
    public float timeDelay;

    /**
     * Pre:---
     * Post: metodo en el cual se inicia la corutina la cual gestiona el parpadeo.
     */
    void Update()
    {
        if (titila == false)
        {
            StartCoroutine(LuzQueTitila());
        }
    }

    /**
     * Pre:---
     * Post: metodo que se encarga de la manera en la cual parpadea la luz.
     */
    IEnumerator LuzQueTitila()
    {
        titila = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(0.01f, 0.4f);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timeDelay = Random.Range(0.01f, 0.4f);
        yield return new WaitForSeconds(timeDelay);
        titila = false;
    }
}