using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Clase la cual define el conportamiento de las puertas en el juego.
 */
public class Door : Interactable
{

    private bool isOpen = false;
    private bool canBeInteractedWith = true;
    private Animator anim;

    public AudioClip openDoor;
    public AudioClip closeDoor;

    /**
     * Pre:---
     * Post: metodo en el cual se define las animaciones de las puertas
     */
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public override void OnFocus()
    {
        
    }

    /**
     * Pre:---
     * Post: metodo en el cual se reproduce la accion de la puerta cuando el usuario interactua con ella.
     */
    public override void OnInteract()
    {
        if (canBeInteractedWith)
        {
            isOpen = !isOpen;
            Vector3 doorTransformDirection = transform.TransformDirection(Vector3.forward);
            Vector3 playerTransformDirection = FirstPersonController.instance.transform.position - transform.position;
            float dot = Vector3.Dot(doorTransformDirection, playerTransformDirection);
            anim.SetFloat("dot", dot);
            anim.SetBool("isOpen", isOpen);
            StartCoroutine(AutoClose());
        }
    }
    

    public override void OnLoseFocus()
    {
        
    }

    /**
     * Pre:---
     * Post: metodo el cual comprueba si la puerta esta abierta, de este modo no se puede interrumpir
     *       la acción de la puerta en medio de la accion.
     */
    private IEnumerator AutoClose()
    {
        while(isOpen)
        {
            yield return new WaitForSeconds(3);

            if(Vector3.Distance(transform.position, FirstPersonController.instance.transform.position) > 3)
            {
                isOpen = false;
                anim.SetFloat("dot", 0);
                anim.SetBool("isOpen", isOpen);
            }
        }
    }

    private void Animator_LockInteraction()
    {
        canBeInteractedWith = false;
    }

    private void Animator_UnlockInteraction()
    {
        canBeInteractedWith = true;
    }

    /**
     * Pre:---
     * Post: metodo que reproduce el sonido de cuando la puerta de abre
     */
    private void AudioOpenDoor()
    {
        AudioSource.PlayClipAtPoint(openDoor, transform.position, 5);
    }

    /**
     * Pre:---
     * Post: metodo que reproduce el sonido de cuando la puerta de cierra
     */
    private void AudioCloseDoor()
    {
        AudioSource.PlayClipAtPoint(closeDoor, transform.position, 5);
    }
}
