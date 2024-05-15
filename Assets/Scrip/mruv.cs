using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mruv : MonoBehaviour
{
    public Transform target;
    public float acceleration = 0.1f;
    private Vector3 velocity = Vector3.zero;

    void Update()
    {
        Vector3 direction = target.position - transform.position;
        velocity += direction * acceleration * Time.deltaTime;

        transform.position += velocity * Time.deltaTime;
        Debug.Log("Velocidad: " + velocity.magnitude);

    }
}
