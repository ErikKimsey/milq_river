using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCanopy : MonoBehaviour
{
    ParticleSystem particleSystem;
    void Start()
    {
        particleSystem = GetComponentInChildren<ParticleSystem>();
        Debug.Log(particleSystem.name);
    }



    /**
    -- Canopy object needs collision detector,
    -- On collision:
    ---- Animate canopy object as shaking, then...
    ---- Play associated particle system,
    ---- Particles segue into psychedelic scene transition
    
    */

    // Update is called once per frame
