using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particles_control : MonoBehaviour {
    public ParticleSystem particle_left;
    public ParticleSystem particle_right;
    public ParticleSystem explosion;
    public AudioSource beam_sound;
    public AudioSource explosion_sound;

    public UnityEngine.UI.Text descriptions;

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
        descriptions.text = "2 photons (light particles) from the LHC collide at \nthe centre of the ATLAS detector. ";
        particle_left.Play();
        particle_right.Play();
        beam_sound.Play();
        Debug.Log("start wait");
        yield return new WaitForSeconds(2.5f);
        Debug.Log("end particles");
        particle_left.Stop();
        particle_right.Stop();
        beam_sound.Stop();
        explosion.Play();
        explosion_sound.Play();
        descriptions.text = "2 photons (light particles) from the LHC collide at \nthe centre of the ATLAS detector. \nThe high energy collision forms new particles, which \nfly out in all directions.\n'Primary' particles are formed in this collision, like \nMuons and Higgs particles.";
        StartCoroutine(activateExplosion());
    }

    IEnumerator activateExplosion()
    {
        
        yield return new WaitForSeconds(3);
        explosion.Stop();
        explosion_sound.Stop();
    }
}
