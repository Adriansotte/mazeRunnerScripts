using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/**
 * Clase que muestra al jugador mediante pantalla los valores de su estamina y su vida.
 */
public class UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText = default;
    [SerializeField] private TextMeshProUGUI staminaText = default;

    /**
     * Pre:---
     * Post: metodo en el cual se gestiona el incremento de salud y estamina
     */
    private void OnEnable()
    {
        FirstPersonController.OnDamage += UpdateHealth;
        FirstPersonController.OnHeal += UpdateHealth;
        FirstPersonController.OnStaminaChange += UpdateStamina;
    }

    /**
     * Pre:---
     * Post: metodo en el cual se gestiona el descenso de salud y estamina
     */
    private void OnDisable()
    {
        FirstPersonController.OnDamage -= UpdateHealth;
        FirstPersonController.OnHeal -= UpdateHealth;
        FirstPersonController.OnStaminaChange -= UpdateStamina;
    }

    /**
     * Pre:---
     * Post: metodo en el cual se inicializa los valores del jugadores
     */
    private void Start()
    {
        UpdateHealth(100);
        UpdateStamina(100);
    }

    /**
     * Pre:---
     * Post: metodo el cual gestiona el valor de la vida en la UI
     */
    private void UpdateHealth(float currentHealth)
    {
        healthText.text = currentHealth.ToString("00");
    }

    /**
     * Pre:---
     * Post: metodo el cual gestiona el valor de la stamina en la UI
     */
    private void UpdateStamina(float currentStamina)
    {
        staminaText.text = currentStamina.ToString("00");
    }

}
