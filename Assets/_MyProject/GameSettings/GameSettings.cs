using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "GameSettings", menuName = "ScriptableObjects/GameSettings", order = 1)]
public class GameSettings : ScriptableObject
{

    [SerializeField] private int SoulAmount;
    public int soulAmount { get { return SoulAmount; } set { SoulAmount = value; } }
}
