using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class BaseMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private NavMeshAgent navMeshAgent;
    [SerializeField] private Transform destinationPoint;
    private Vector3 lastPosition;
    private bool isStop;
    void Start()
    {
        navMeshAgent.destination = destinationPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (lastPosition==transform.position && isStop==false)
        {
            isStop = true;
        }
        lastPosition = transform.position;
        if (isStop)
        {
            //_rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
          //  transform.position = new Vector3(transform.position.x, transform.position.y + 10f, transform.position.z);
        }
    }
}
