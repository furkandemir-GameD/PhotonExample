using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;

public class AgentBaseController : MonoBehaviour
{
    [SerializeField] private AIProperties aIProperties;
    [SerializeField] private NavMeshAgent navMeshAgent;
    [SerializeField] private Transform[] linkPoints;
    [SerializeField] private Transform finalPoint;
    private int index;
    private AgentJumpToTarget agentJumpToTarget;
    //   private void Awake() => gameObject.AddComponent<AgentJumpToTarget>();
    private void Awake() => agentJumpToTarget = GameObject.FindWithTag("AI").GetComponent<AgentJumpToTarget>();

    private void Start()
    {
        Run.After(0f, () => {
            {
                AgentJumpToTarget agentProps = gameObject.AddComponent<AgentJumpToTarget>();              
                agentProps.target = linkPoints[index];
                agentProps.aIProperties = aIProperties;
                agentProps.GetStartPointAndMoveToPosition();
                Run.After(3f, () => { agentProps.PerformJump(); });
                index++;
            }
        });
        Run.After(5f, () => {
            {
                Destroy(gameObject.GetComponent<AgentJumpToTarget>());
                AgentJumpToTarget agentProps = gameObject.AddComponent<AgentJumpToTarget>();
                agentProps.target = linkPoints[index];
                agentProps.aIProperties = aIProperties;
                agentProps.GetStartPointAndMoveToPosition();
                Run.After(3f, () => { agentProps.PerformJump(); });
              
                index++;
            }
        });
        Run.After(10f, () => {
            {
                Destroy(gameObject.GetComponent<AgentJumpToTarget>());
                AgentJumpToTarget agentProps = gameObject.AddComponent<AgentJumpToTarget>();
                agentProps.target = linkPoints[index];
                agentProps.aIProperties = aIProperties;
                agentProps.GetStartPointAndMoveToPosition();
                Run.After(3f, () => { agentProps.PerformJump(); });
               
                index++;
            }
        });
        Run.After(15f, () => {
            {
                Destroy(gameObject.GetComponent<AgentJumpToTarget>());
                AgentJumpToTarget agentProps = gameObject.AddComponent<AgentJumpToTarget>();
                
                agentProps.aIProperties = aIProperties;
                // agentProps.GetStartPointAndMoveToPosition();
                transform.DOMove(linkPoints[index].position,2f);
                index++;
                agentProps.target = linkPoints[index];
                Debug.Log(agentProps.target);
                Run.After(3f, () => { agentProps.PerformJump(); });
               
               
            }
        });
        Run.After(20, () => { transform.DOMove(finalPoint.position,2f); });

    }
   
    private void RemoveCompenent(){
        Destroy(gameObject.GetComponent<AgentJumpToTarget>());
    }
}
