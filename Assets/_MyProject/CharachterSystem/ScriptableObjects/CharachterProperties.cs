using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharachterProperties", menuName = "ScriptableObjects/CharachterProperties", order = 1)]
public class CharachterProperties : ScriptableObject
{
    [SerializeField] private float MovementSpeed;
    public float movementSpeed { get { return MovementSpeed; } private set { MovementSpeed = value; } }


    [SerializeField] private float jumpForce;
    public float jumpSpeed { get { return jumpForce; } private set { jumpForce = value; } }

    [SerializeField] private float MaxVelocity;
    public float maxVelocity { get { return MaxVelocity; } private set { MaxVelocity = value; } }

    [SerializeField] private float VisualFriction;
    public float visualFriction { get { return VisualFriction; } private set { VisualFriction = value; } }

    [SerializeField] private AudioClip JumpSound;
    public AudioClip jumpSound { get { return JumpSound; } private set { JumpSound = value; } }

}
