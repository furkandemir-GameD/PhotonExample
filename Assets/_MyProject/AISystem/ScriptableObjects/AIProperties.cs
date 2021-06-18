using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "AIProperties", menuName = "ScriptableObjects/AIProperties", order = 1)]
public class AIProperties : ScriptableObject
{
    [SerializeField] private bool IsStart;
    public bool isStart { get { return IsStart; } private set { IsStart = value; } }

    [SerializeField] private NavMeshAgent AINavMeshAgent;
    public NavMeshAgent aINavMeshAgent { get { return AINavMeshAgent; } private set { AINavMeshAgent = value; } }

    [SerializeField] private Rigidbody Rigidbody;
    public Rigidbody rigidBody { get{ return Rigidbody; } set{ Rigidbody = value; } }

    [SerializeField] private Transform TargetTransform;
    public Transform targetTransform { get { return TargetTransform; } set { TargetTransform = value; } }

    [SerializeField] private float ReachedStartPoint;
    public float reachedStartPoint { get { return ReachedStartPoint; } set { ReachedStartPoint = value; } }

    [SerializeField] private Transform DummyAgent;
    public Transform dummyAgent { get { return DummyAgent; } set { DummyAgent = value; } }

    [SerializeField] private Vector3 EndJumpPosition;
    public Vector3 endJumpPosition { get { return EndJumpPosition; } set { EndJumpPosition = value; } }

    [SerializeField] private float MaxJumpableDistance;
    public float maxJumpableDistance { get { return MaxJumpableDistance; } set { MaxJumpableDistance = value; } }

    [SerializeField] private float JumpTime;
    public float jumpTime { get { return JumpTime; } set { JumpTime = value; } }

    [SerializeField] private float AddToJumpHeight;
    public float addToJumpHeight { get { return AddToJumpHeight; } set { AddToJumpHeight = value; } }

    [SerializeField] private Vector3 JumpStartPoint;
    public Vector3 jumpStartPoint { get { return JumpStartPoint; } set { JumpStartPoint = value; } }

    [SerializeField] private bool IsStopFlag;
    public bool isStopFlag { get { return IsStopFlag; } set { IsStopFlag = value; } }
}
