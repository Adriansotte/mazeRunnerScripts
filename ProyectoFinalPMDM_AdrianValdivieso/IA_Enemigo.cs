using UnityEngine;
using UnityEngine.AI;

/**
 * Clase que se encarga del comportamiento de la inteligencia artificial dentro del juego
 */
public class SeguirJugador : MonoBehaviour
{
    public Transform jugador;
    private NavMeshAgent agente;
    private Animator animador;

    /**
     * Pre:---
     * Post: metodo el cual rastrea la posicion exacta del jugador y mueve al enemigo a dicha posicion.
     */
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        animador = GetComponent<Animator>();

        if (jugador == null)
        {
            jugador = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    void Update()
    {
        agente.SetDestination(jugador.position);

        // Determina si el enemigo está en movimiento
        bool enMovimiento = agente.velocity.magnitude > 0.1f;

        // Actualiza la variable del Animator
        animador.SetBool("IsMoving", enMovimiento);
    }
}
