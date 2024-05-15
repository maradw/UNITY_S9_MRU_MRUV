using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRU : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float velocity;
    private int currentPoint = 0;
    [SerializeField] private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float x = velocity * (Time.time - startTime);
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPoint].position, x);
        if (transform.position == patrolPoints[currentPoint].position)
        {
            currentPoint++;
            startTime = Time.time;
        }
        if (currentPoint == patrolPoints.Length)
        {
            currentPoint = 0;
        }
    }
}
