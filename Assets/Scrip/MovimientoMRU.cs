using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MovimientoMRU : MonoBehaviour
{
    public Transform puntoDestino;
    public float velocidadInicial;
    public TextMeshProUGUI texto;
    private bool Llegado = false;
    private float tiempo = 0;

    void Update()
    {
        if (!Llegado)
        {
            tiempo += Time.deltaTime;
            float distancia = velocidadInicial * tiempo;
            float step = velocidadInicial * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, puntoDestino.position, step);
            texto.text = "Velocidad Inicial: " + velocidadInicial.ToString("F2") + " Tiempo: " + tiempo.ToString("F2") + " Distancia: " + distancia.ToString("F2");

            if (transform.position == puntoDestino.position)
            {
                Llegado = true;
            }
        }
    }
}
