using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FnalPointDetecton : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("AI"))
        {
            //GameManager.Instance.FailGame();
        }
        if (collision.transform.CompareTag("Player"))
        {
            //GameManager.Instance.WinGame();
        }
    }
}
