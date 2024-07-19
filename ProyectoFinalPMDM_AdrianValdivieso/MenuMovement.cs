using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Clase que gestiona el movimiento del fonde de pantalla del menu.
 */
public class MenuMovement : MonoBehaviour
{

    float mousePosX;
    float mousePosY;

    [SerializeField] float moveQuantity;

    /**
     * Pre:---
     * Post: metodo el cual rastrea la posicion del raton para generar el movimiento del fondo.
     */
    void Update()
    {
        mousePosX = Input.mousePosition.x;
        mousePosY = Input.mousePosition.y;

        this.GetComponent<RectTransform>().position = new Vector2(
            (mousePosX / Screen.width) * moveQuantity + (Screen.width / 2),
            (mousePosY / Screen.height) * moveQuantity + (Screen.height / 2));


    }
}
