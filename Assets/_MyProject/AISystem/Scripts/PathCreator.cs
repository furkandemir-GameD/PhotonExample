using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathCreator : MonoBehaviour
{
    [SerializeField] private float sphereRadius;
    //[SerializeField] private Transform[] pointsTransforms = new Transform[100];
    public List<Transform> pointsTransforms = new List<Transform>();

    private void OnDrawGizmos()
    {

        for (int i = 0; i < pointsTransforms.Count; i++)
        {
            Gizmos.DrawSphere(pointsTransforms[i].position, sphereRadius);
            if (i > 0)
            {
                Gizmos.DrawLine(pointsTransforms[i - 1].position, pointsTransforms[i].position);
            }
        }
    }
}

