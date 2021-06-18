using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class OfssetCalculator : MonoBehaviour
{
    [SerializeField] private Transform finalPoint;
    private float ofsset;
    void Update()
    {
        ofsset =finalPoint.position.x - transform.position.x;
        Debug.Log(-ofsset);
    }
}
