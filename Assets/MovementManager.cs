using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    [SerializeField] private LayerMask maskHit;
    [SerializeField] private float maxDistance;
    private RaycastHit hitInfo;
    private bool isClick;
    private GameObject hitObject;
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
           // ray.direction = Camera.main.transform.forward;
            //ay.origin = Camera.main.transform.position;
            if (Physics.Raycast(ray,out hitInfo, 100f, maskHit))
            {
                Debug.Log(hitInfo.transform.name);
                isClick = true;
                hitObject = hitInfo.transform.gameObject;
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            isClick = false;
        }
        if (isClick)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 3.5f;
            hitObject.GetComponent<Rigidbody>().transform.position = Camera.main.ScreenToWorldPoint(mousePos);
        }
    }
    private void OnDrawGizmos()
    {
        Ray ray = new Ray();
        ray.direction = Camera.main.transform.forward;
        ray.origin = Camera.main.transform.position;
        Gizmos.DrawRay(ray);
    }
}
