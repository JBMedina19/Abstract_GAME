﻿using UnityEngine;

[System.Serializable]
public abstract class WeaponAbilities : MonoBehaviour
{
    public abstract void Attack();
    public abstract void Skill();
    public abstract void Ultimate();
}


