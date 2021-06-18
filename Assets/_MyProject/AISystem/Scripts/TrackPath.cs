using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class TrackPath : MonoBehaviour
{
    private int linearInterpolation = 0;
    [SerializeField] private PathCreator pathCreator;
    public PathType pathType = PathType.CubicBezier;
    private Rigidbody _rb;
    void Awake() => _rb = GetComponent<Rigidbody>();
    private void Start()
    {
        Vector3[] transforms = new Vector3[pathCreator.pointsTransforms.Count];
        for (int i = 0; i < pathCreator.pointsTransforms.Count; i++)
        {
            transforms[i] = pathCreator.pointsTransforms[i].position;
        }
        _rb.DOPath(transforms, 25f, pathType,PathMode.Ignore,100,Color.red);
    }
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, pathCreator.pointsTransforms[linearInterpolation].position, 0.5f * Time.deltaTime);
        if (transform.position == pathCreator.pointsTransforms[linearInterpolation].position)
        {
            Debug.Log("interpolation");
            linearInterpolation++;
            Run loop = Run.EachFrame( () => {
                //transform.position = Vector3.Lerp(pathCreator.pointsTransforms[0].position,
                  //     pathCreator.pointsTransforms[1].position, 0.5f * Time.deltaTime);
          
            });
            Run.After(10f, loop.Abort);
        }
    }
}
