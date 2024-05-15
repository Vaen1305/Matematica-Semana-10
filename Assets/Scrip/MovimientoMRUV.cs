using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MovimientoMRUV : MonoBehaviour
{
    public Transform puntoDestino;
    public float aceleracion;
    public float velocidadInicial;
    public TextMeshProUGUI texto;
    private Vector3 posicionInicial;
    private bool Llegado = false;
    private float tiempo = 0;

    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        if (!Llegado)
        {
            tiempo += Time.deltaTime;
            float distancia = velocidadInicial * tiempo + 0.5f * aceleracion * tiempo * tiempo;
            Vector3 direccion = (puntoDestino.position - posicionInicial).normalized;
            transform.position = posicionInicial + direccion * distancia;
            texto.text = "Velocidad Inicial: " + velocidadInicial.ToString("F2") + " Tiempo: " + tiempo.ToString("F2") + " Aceleración: " + aceleracion.ToString("F2") + " Distancia: " + distancia.ToString("F2");

            if (Vector3.Distance(transform.position, puntoDestino.position) < 0.1f)
            {
                Llegado = true;
            }
        }
    }
}
