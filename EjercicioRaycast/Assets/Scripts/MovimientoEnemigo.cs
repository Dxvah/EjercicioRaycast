using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{

    public Transform objetivo;
    public int minVelocidad;
    public int maxVelocidad;
    public int posMinima;
    public int posMaxima;
    int velocidad;

    void Start()
    {
        // Posición Enemigo.
        transform.position = DevolverPosicionEnemigo();
        // Velocidad Enemigo.
        velocidad = Random.Range(minVelocidad, maxVelocidad);
    }

    void Update()
    {
        // Persecución del Jugador.
        transform.position = Vector3.MoveTowards(transform.position, objetivo.position, velocidad);
    }


    Vector3 DevolverPosicionEnemigo()
    {
        float x = Random.Range(-posMinima, posMaxima);
        float y = objetivo.position.y;
        float z = Random.Range(-posMinima, posMaxima);

        return new Vector3(x, y, z);   
    }
}
