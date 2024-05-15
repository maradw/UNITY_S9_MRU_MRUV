using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MRUV : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textResult;
    [SerializeField] private Transform target;
    [SerializeField] private float initialVelocity;
    [SerializeField] private float startTime;
    [SerializeField] private float acceleration;
    [SerializeField] private float result;
    public float currentTime = 0;
    Vector3 startPosition;

    void Start()
    {
        startTime = Time.time;
    }
    
    void Update()
    {
        SetResult();
        
        currentTime = Time.time -startTime;
        result = initialVelocity * currentTime + (acceleration * Mathf.Pow(currentTime, 2) / 2);
        transform.position = Vector3.MoveTowards(transform.position, target.position, result);
        if (transform.position == target.position)
        {
            /*acceleration = 0;
            currentTime = 0;
            initialVelocity = 0;*/
        }
    }
    void SetResult()
    {
        _textResult.text = " resultado: " + result;
    }
}
