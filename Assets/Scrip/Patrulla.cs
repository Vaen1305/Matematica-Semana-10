using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrulla : MonoBehaviour
{
    public Transform[] points;
    public float[] times;
    private int currentPoint = 0;
    private float speed;

    void Start()
    {
        if (points.Length != times.Length)
        {
            return;
        }
        GoToNextPoint();
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, points[currentPoint].position, speed * Time.deltaTime);

        if (transform.position == points[currentPoint].position)
        {
            GoToNextPoint();
        }
    }

    void GoToNextPoint()
    {
        currentPoint = (currentPoint + 1) % points.Length;

        float distance = Vector3.Distance(transform.position, points[currentPoint].position);

        speed = distance / times[currentPoint];

        Debug.Log("Distancia al siguiente punto: " + distance);
    }
}
