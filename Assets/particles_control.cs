using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particles_control : MonoBehaviour {
    public ParticleSystem particle_left;
    public ParticleSystem particle_right;
    public ParticleSystem explosion;

    // Use this for initialization
    void Start () {
        particle_left.Stop();
        particle_right.Stop();
        explosion.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            Debug.Log("start particles");
            StartCoroutine(activateParticles());
        }
    }

    IEnumerator activateParticles()
    {
        particle_left.Play();
        particle_right.Play();
        Debug.Log("start wait");
        yield return new WaitForSeconds(2.5f);
        Debug.Log("end particles");
        particle_left.Stop();
        particle_right.Stop();
        explosion.Play();
        StartCoroutine(activateExplosion());
    }

    IEnumerator activateExplosion()
    {
        
        yield return new WaitForSeconds(3);
        explosion.Stop();
    }
}
