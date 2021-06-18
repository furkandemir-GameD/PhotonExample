using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;
//using Sirenix.OdinInspector;
        
//brought to you by M dot Strange
// delete the using.SirenX.Odin.. above if you don't have it

public class AgentJumpToTarget : MonoBehaviour
{
    public AIProperties aIProperties;
    public bool isStart;
    public Transform target;
    /*public NavMeshAgent NavMeshAgent;
    public Rigidbody Rigidbody;
    public GameObject Target;
    public float ReachedStartPointDistance = 0.5f;
    [SerializeField] private Transform DummyAgent;
    [SerializeField] private Vector3 EndJumpPosition;
    [SerializeField] private float MaxJumpableDistance = 80f;
    [SerializeField] private float JumpTime = 0.6f;
    [SerializeField] private float AddToJumpHeight;
    [SerializeField] private Vector3 JumpStartPoint;*/

   // [SerializeField] private Vector3 jumpStartPoint;
   // [SerializeField] private Vector3 endJumpPosition;

    private Transform _dummyAgent;
    private Vector3 JumpMidPoint;
    private Vector3 JumpEndPoint;
    private bool checkForStartPointReached;
    private Transform _transform;
    private List<Vector3> Path = new List<Vector3>();
    private float JumpDistance;
    private Vector3[] _jumpPath;
    private bool previousRigidBodyState;

    // remove the [Button] code if you don't have Odin
    private void Start()
    {
        isStart = true;
    }
   // [Button]
    public void GetStartPointAndMoveToPosition()
    {
        isStart = true;
        aIProperties.isStopFlag = false;
        aIProperties.jumpStartPoint = GetJumpStartPoint();
        MoveToStartPoint();
        
    }

    // remove the [Button] code if you don't have Odin
 //   [Button]
    public void PerformJump()
    {
        SpawnAgentAndGetPoint();
    }

    private void OnEnable()
    {
        checkForStartPointReached = false;
        _transform = transform;
    }

    Vector3 GetJumpStartPoint()
    {
        NavMeshPath hostAgentPath = new NavMeshPath();
        aIProperties.aINavMeshAgent.CalculatePath(target.transform.position, hostAgentPath);

        var endPointIndex = hostAgentPath.corners.Length - 1;
        return hostAgentPath.corners[endPointIndex];

        //Improvement to make- get the jump distance using the start and end point
        // use that to set the Jump Time
    }

    void MoveToStartPoint()
    {
        checkForStartPointReached = true;
        aIProperties.aINavMeshAgent.isStopped = false;
        aIProperties.aINavMeshAgent.SetDestination(aIProperties.jumpStartPoint);
    }

    void ReadyToJump()
    {
        //Do your pre_jump animation
    }

    void SpawnAgentAndGetPoint()
    {
        // If using Pooling Spawn here instead
        _dummyAgent = Instantiate(aIProperties.dummyAgent, target.transform.position, Quaternion.identity);
        var info = _dummyAgent.GetComponent<ReturnNavmeshInfo>();
        aIProperties.endJumpPosition = info.ReturnClosestPointBackToAgent(transform.position);
        aIProperties.endJumpPosition = aIProperties.endJumpPosition;

        MakeJumpPath();

    }

    void MakeJumpPath()
    {
        Path.Add(aIProperties.jumpStartPoint);

        var tempMid = Vector3.Lerp(aIProperties.jumpStartPoint, aIProperties.endJumpPosition, 0.5f);
        tempMid.y = tempMid.y + aIProperties.aINavMeshAgent.height + aIProperties.addToJumpHeight;

        Path.Add(tempMid);

        Path.Add(aIProperties.endJumpPosition);

        JumpDistance = Vector3.Distance(aIProperties.jumpStartPoint, aIProperties.endJumpPosition);

        if (JumpDistance <= aIProperties.maxJumpableDistance)
        {
            DoJump();
        }
        else
        {
            Debug.Log("Too far to jump");
        }
    }

    void DoJump()
    {
        previousRigidBodyState = aIProperties.rigidBody.isKinematic;
        aIProperties.aINavMeshAgent.enabled = false;
        aIProperties.rigidBody.isKinematic = true;

        _jumpPath = Path.ToArray();

        // if you don't want to use a RigidBody change this to
        //transform.DoLocalPath per the DoTween doc's
        aIProperties.rigidBody.DOLocalPath(_jumpPath, aIProperties.jumpTime  , PathType.CatmullRom).OnComplete(JumpFinished);
    }

    void JumpFinished()
    {
        aIProperties.aINavMeshAgent.enabled = true;
        aIProperties.rigidBody.isKinematic = previousRigidBodyState;

        // If using Pooling DeSpawn here instead
        Destroy(_dummyAgent.gameObject);
    }

    private void Update()
    {
        if(checkForStartPointReached)
        {
            var distance = (_transform.position - aIProperties.jumpStartPoint).sqrMagnitude;
            
            if (distance <= aIProperties.reachedStartPoint * aIProperties.reachedStartPoint)
            {
                ReadyToJump();

                if(aIProperties.aINavMeshAgent.isOnNavMesh)
                {
                    aIProperties.aINavMeshAgent.isStopped = true;
                }
               
                checkForStartPointReached = false;               
            }           
        }
    }
}
