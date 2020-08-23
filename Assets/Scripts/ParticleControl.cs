using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.ParticleSystemModule;

// [RequireComponent(typeof(ParticleSystem))]
public class ParticleControl : MonoBehaviour
{
    // Start is called before the first frame update
    private ParticleSystem ps;
    private Transform targetTransform;
    public GameObject target;
    private static ParticleSystem.Particle[] particles  = new ParticleSystem.Particle[1000];

    void Start()
    {
        targetTransform = target.transform;
        Debug.Log(targetTransform);
        ps = GetComponent<ParticleSystem>();
        // HandleParticleEmission();
    }

    private void HandleParticleEmission(){

        if (ps == null) ps = GetComponent<ParticleSystem>();
        
        int count = ps.GetParticles(particles);
       
        for (int i = 0; i < count; i++)
        {
            float distance = Vector3.Distance(targetTransform.position, particles[i].position);
            Debug.Log(distance);
           
            if (distance > 0.1f)
            {
                particles[i].position = Vector3.Lerp(particles[i].position, targetTransform.position, Time.deltaTime / 2.0f);
            }
        }
        ps.SetParticles(particles, count);
    }

    // Update is called once per frame
    void LateUpdate()
    {
       HandleParticleEmission();
    }
}
