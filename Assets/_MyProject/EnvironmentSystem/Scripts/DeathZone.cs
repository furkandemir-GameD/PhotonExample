using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //GameManager.Instance.SoulDecrease();
        }
        else if (other.gameObject.CompareTag("AI"))
        {
        //    GameManager.Instance.FailGame();
        }
    }
}
