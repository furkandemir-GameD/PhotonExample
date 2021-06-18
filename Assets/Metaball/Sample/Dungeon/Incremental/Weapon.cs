﻿//--------------------------------
// Skinned Metaball Builder
// Copyright © 2015 JunkGames
//--------------------------------

using UnityEngine;
using System.Collections;

public abstract class Weapon : MonoBehaviour {

    public GameObject weaponBody;
    public IMBrush brush;

    public Animator animator;
    public AudioSource audioSource;
    
    protected abstract void DoShoot(DungeonControl2 dungeon, Vector3 from, Vector3 to);

    public AudioClip equipAudio;
    public AudioClip shotAudio;


    public void Shoot(DungeonControl2 dungeon, Vector3 from, Vector3 to)
    {
        if (audioSource != null && shotAudio != null)
        {
            audioSource.PlayOneShot(shotAudio);
        }
        DoShoot(dungeon, from, to);
    }

    public void OnEquip()
    {
        animator.SetBool("EQUIP", true);
        if( audioSource != null && equipAudio != null )
        {
            audioSource.PlayOneShot(equipAudio);
        }
    }

    public void OnRemove()
    {
        animator.SetBool("EQUIP", false);
    }
}
