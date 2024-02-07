using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GreatSword : WeaponAbilities
{
    private ParticleSystem attack, skill, ultimate;
    private Transform showParticleTransform;
    public override void Attack() { attack = AbilityManager.Instance.AttackFX[0]; }
    public override void Skill() { skill = AbilityManager.Instance.SkillFX[0]; }
    public override void Ultimate() 
    { 
        ultimate = AbilityManager.Instance.UltimateFX[0];
        Instantiate(ultimate);
        ultimate.Play();
    }
}
