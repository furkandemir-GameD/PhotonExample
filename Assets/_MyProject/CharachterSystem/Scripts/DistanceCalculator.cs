using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCalculator 
{
   public static bool DistanceCalculate(Transform pointObject,LayerMask hitObjectsLayer)
    {
        bool hasHit;
        RaycastHit hitInfo;
        hasHit = Physics.Raycast(pointObject.position,-pointObject.up,out hitInfo,100, hitObjectsLayer);
        return hasHit;
    }
}
