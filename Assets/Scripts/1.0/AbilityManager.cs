using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityManager : MonoBehaviour
{
    public static AbilityManager Instance { get; private set; }
    public List<ParticleSystem> AttackFX = new List<ParticleSystem>();
    public List<ParticleSystem> SkillFX = new List<ParticleSystem>();
    public List<ParticleSystem> UltimateFX = new List<ParticleSystem>();
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
}


