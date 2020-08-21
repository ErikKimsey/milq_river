using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCanopy : MonoBehaviour {

    public GameObject particleSystem;
    ParticleSystem ps;

    private void Awake() {
        
    }
    
    private void Start(){
        
    }

    void OnCollisionEnter(Collision other) {
        Debug.Log(other);
    }

    public void InitShake(){
        Debug.Log("InitSHake");
    }

    public void PlayParticles(){
        Debug.Log(particleSystem);
        GameObject clone = Instantiate(particleSystem, transform.position, Quaternion.identity);
        Debug.Log(clone);
        clone.GetComponent<ParticleSystem>().Play();
   
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
