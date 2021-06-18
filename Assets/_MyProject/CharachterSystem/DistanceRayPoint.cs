using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceRayPoint : MonoBehaviour
{
    [SerializeField] private float maxDistance;
    [SerializeField] private float radius;
    [SerializeField] private Vector3 direction;
    [SerializeField] private CharachterController charachterController;
    [SerializeField] private LayerMask hitMask;
    private RaycastHit hitInfo;
    private bool hitActive;
    void Update()
    {
        hitActive = Physics.SphereCast(transform.position, radius, direction,out hitInfo, maxDistance, hitMask);
        charachterController.jumpControl = hitActive;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, radius);
    }
}
