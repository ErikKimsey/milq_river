using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCanopy : MonoBehaviour {

    public ParticleSystem particleSystem;

    private void Awake() {
        particleSystem = GetComponent<ParticleSystem>();
    }
    
    private void Start(){

    }

    public void InitShake(){
        Debug.Log("InitSHake");
    }

    public void PlayParticles(){
        Debug.Log("particleSystem");
        Debug.Log(particleSystem);
    }


}
    /**
    -- Canopy object needs collision detector,
    -- On collision:
    ---- Animate canopy object as shaking, then...
    ---- Play associated particle system,
    ---- Particles segue into psychedelic scene transition
    
    */

    // Update is called once per frame
