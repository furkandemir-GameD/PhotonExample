using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ServerProperties", menuName = "ScriptableObjects/ServerProperties", order = 1)]
public class ServerProperties : ScriptableObject
{
   
    [SerializeField] private byte RoomMaxPlayer;
    public byte roomMaxPlayer { get { return RoomMaxPlayer; } private set { RoomMaxPlayer = value; } }

    [SerializeField] private bool ServerIsOpen;
    public bool serverIsOpen { get { return ServerIsOpen; } private set { ServerIsOpen = value; } }

    [SerializeField] private bool ServerIsVisible;
    public bool serverIsVisible { get { return ServerIsVisible; } private set { ServerIsVisible = value; } }

}
