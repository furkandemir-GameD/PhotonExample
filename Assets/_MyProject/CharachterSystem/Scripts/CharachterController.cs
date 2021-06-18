using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharachterController : MonoBehaviour, ICharachterController
{
    public bool  jumpControl {  get; set; }
    public Animator charachterAnimator;
    [SerializeField] private float startRot;
    [SerializeField] private Transform charachterRoot;
    [SerializeField] private CharachterProperties charachterProperties;
    public Rigidbody _rb;
    private float horizontalValue;
    private float verticalValue;
    private Vector3 velocityChange;
    private bool hasClick;
    private bool hasAvailable = true;
    private const float gravityValue = -9.81f;
  //  [SerializeField] private VolumeManager volumeManager;
    [SerializeField] Animation jumpAnimation;
    private float JumpAnimationTime;
    public float jumpAnimationTime { get { return JumpAnimationTime; } private set { JumpAnimationTime = value; } }


    void Awake() => Init();

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            DeltaCalculator();
            charachterAnimator.SetBool("CanRun", true);
        }
        if (Input.GetMouseButtonUp(0) )
        {
            hasClick = false;
            charachterAnimator.SetBool("CanRun", false);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }//geçici 
    }
    private void FixedUpdate()
    {
        BasePyhsicsMovement();
        VelocityLimitation();
    }
    private void Init()
    {
        _rb = GetComponent<Rigidbody>();
    }
    public void Jump()
    {
        if (jumpControl)
        {
            _rb.AddForce(Vector3.up * charachterProperties.jumpSpeed, ForceMode.Impulse);
            charachterAnimator.SetBool("CanRun", false);
            charachterAnimator.SetBool("CanJump", true);

           // volumeManager.SetVolumeProperties(charachterProperties.jumpSound,this.gameObject);
            /*DelayedExecution.Do(0.5f, async () => {
                charachterAnimator.SetBool("CanJump", false);
            }); */
        }
    }
    public void VelocityLimitation()
    {
        if (_rb.velocity.magnitude > charachterProperties.maxVelocity)
        {
            _rb.velocity = _rb.velocity.normalized * charachterProperties.maxVelocity;
        }
    }
    public void BasePyhsicsMovement()
    {
        if (hasClick)
        {
            _rb.AddForce(velocityChange * charachterProperties.movementSpeed);
        }
        else
        {
            _rb.velocity = Vector3.Lerp(_rb.velocity, Vector3.zero, charachterProperties.visualFriction * Time.deltaTime);
        }
    }
    public void DeltaCalculator()
    {
        hasClick = true;
        velocityChange = _rb.velocity;

        horizontalValue = SimpleInput.GetAxis("Horizontal2");
        verticalValue = SimpleInput.GetAxis("Vertical2");
        
        velocityChange.x = -verticalValue;
        velocityChange.y = 0;
        velocityChange.z = horizontalValue;

        float myAngle = Mathf.Atan2(horizontalValue, verticalValue) * Mathf.Rad2Deg;
        charachterRoot.eulerAngles = new Vector3(0, startRot + myAngle, 0);
    }
}
