using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xray_vision : MonoBehaviour {
    public GameObject muonBarrelout;
    public GameObject muonBarrelmid;
    public GameObject muontoroidsbarrel;
    public GameObject muonBarrelin;
    public GameObject rtile;
    public GameObject rlar;
    public GameObject rservices;
    public GameObject rtrt;
    public GameObject rsct;
    public GameObject rpixel;
    public AudioSource confirm_sound;
    public AudioSource error_sound;

    public UnityEngine.UI.Text descriptions;

    int stage;

    string[] description_list = { "Stage 0: Exterior Muon Barrel\n\nThe outer-most layer of the muon detector. \nMuons are elementary particles - like electrons \nbut heavier (200x!).\n\nPress Y to learn more about Muons!",
            "Stage 1: Middle Muon Barrel\n\nMuons originate from collisions of cosmic-rays (protons \nspewing out of stars).",
            "Stage 2: Muon Toroids Barrel\n\nMagnetic system made of several superconducting \nmagnets. \nLiquid helium cooled to -269°C keeps the system \nrunning smoothly. \nAn aluminium structure holds the system in place.",
            "Stage 3: Inner Muon Barrel\n\nThe inner-most barrel of the muon detector.",
            "Stage 4: Tile\n\nTiles of Hadronic Calorimeters (HCAL). Measures the \nenergy of 'hadrons' - particles made of quarks and \ngluons (such as protons, neutrons, pions and kaons). \nThis is VERY important to tell scientists if new \nparticles like the Higgs boson are formed.",
            "Stage 5: LAr\n\nConsists of a Electromagnetic Calorimeter (ECAL). \nDetects the energies of emerging particles, especially \nelectrons and photos (important in finding the Higgs \nboson). \nIt is made out of lead tungstate crystals that emit light \nwhen electrons and photos pass through it.",
            "Stage 6: Services\n\nThe service panels provide electrical services for \nthe internal pixel modules (stage 9!).",
            "Stage 7: TRT\n\nTransition Radiation Tracker is the outermost of \nthe three tracking subsystems of the ATLAS \nInner Detector.\nThey consist of 350,000 'straws' that are 4mm wide \nand 39cm long. \nThe TRT can detect if a particle is an electron or \na pion.",
            "Stage 8: SCT\n\nSemiConductor Tracker. Captures the positions of\ncharged particles with an accuracy of 17μm!\nThat is about 4 times thinner than a human hair!",
            "Stage 9: Pixel\n\n80 million pixels track particles at the very beginning \nof the collision.",
            "Stage 10: Beam Pipe\n\nThis is the deepest stage. The beam pipe carries two \nbeams of particles headed straight at each other close \nto the speed of light. \nPress A to activate a photon-photon collision!"
            };

    // Use this for initialization
    void Start () {
        stage = 0;
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("joystick button 3")) {
            if (stage == 0)
            {
                muonBarrelout.GetComponent<Renderer>().enabled = !muonBarrelout.GetComponent<Renderer>().enabled;
                descriptions.text = description_list[1];
                stage = 1;
                confirm_sound.Play();
            }
            else if (stage == 1)
            {
                muonBarrelmid.GetComponent<Renderer>().enabled = !muonBarrelmid.GetComponent<Renderer>().enabled;
                descriptions.text = description_list[2];
                stage = 2;
                confirm_sound.Play();
            }
            else if (stage == 2)
            {
                foreach (Transform child in muontoroidsbarrel.transform)
                {
                    child.GetComponent<Renderer>().enabled = !child.GetComponent<Renderer>().enabled;
                }
                descriptions.text = description_list[3];
                stage = 3;
                confirm_sound.Play();
            }
            else if (stage == 3)
            {
                muonBarrelin.GetComponent<Renderer>().enabled = !muonBarrelin.GetComponent<Renderer>().enabled;
                descriptions.text = description_list[4];
                stage = 4;
                confirm_sound.Play();
            }
            else if (stage == 4)
            {
                rtile.GetComponent<Renderer>().enabled = !rtile.GetComponent<Renderer>().enabled;
                descriptions.text = description_list[5];
                stage = 5;
                confirm_sound.Play();
            }
            else if (stage == 5)
            {
                rlar.GetComponent<Renderer>().enabled = !rlar.GetComponent<Renderer>().enabled;
                descriptions.text = description_list[6];
                stage = 6;
                confirm_sound.Play();
            }
            else if (stage == 6)
            {
                rservices.GetComponent<Renderer>().enabled = !rservices.GetComponent<Renderer>().enabled;
                descriptions.text = description_list[7];
                stage = 7;
                confirm_sound.Play();
            }
            else if (stage == 7)
            {
                rtrt.GetComponent<Renderer>().enabled = !rtrt.GetComponent<Renderer>().enabled;
                descriptions.text = description_list[8];
                stage = 8;
                confirm_sound.Play();
            }
            else if (stage == 8)
            {
                rsct.GetComponent<Renderer>().enabled = !rsct.GetComponent<Renderer>().enabled;
                descriptions.text = description_list[9];
                stage = 9;
                confirm_sound.Play();
            }
            else if (stage == 9)
            {
                rpixel.GetComponent<Renderer>().enabled = !rpixel.GetComponent<Renderer>().enabled;
                descriptions.text = description_list[10];
                stage = 10;
                confirm_sound.Play();
            }
            else
            {
                error_sound.Play();
            }
        }
        else if (Input.GetKeyDown("joystick button 1"))
        {
            if (stage == 1)
            {
                muonBarrelout.GetComponent<Renderer>().enabled = !muonBarrelout.GetComponent<Renderer>().enabled;
                descriptions.text = description_list[0];
                stage = 0;
                confirm_sound.Play();
            }
            else if (stage == 2)
            {
                muonBarrelmid.GetComponent<Renderer>().enabled = !muonBarrelmid.GetComponent<Renderer>().enabled;
                descriptions.text = description_list[1];
                stage = 1;
                confirm_sound.Play();
            }
            else if (stage == 3)
            {
                foreach (Transform child in muontoroidsbarrel.transform)
                {
                    child.GetComponent<Renderer>().enabled = !child.GetComponent<Renderer>().enabled;
                }
                descriptions.text = description_list[2];
                stage = 2;
                confirm_sound.Play();
            }
            else if (stage == 4)
            {
                muonBarrelin.GetComponent<Renderer>().enabled = !muonBarrelin.GetComponent<Renderer>().enabled;
                descriptions.text = description_list[3];
                stage = 3;
                confirm_sound.Play();
            }
            else if (stage == 5)
            {
                rtile.GetComponent<Renderer>().enabled = !rtile.GetComponent<Renderer>().enabled;
                descriptions.text = description_list[4];
                stage = 4;
                confirm_sound.Play();
            }
            else if (stage == 6)
            {
                rlar.GetComponent<Renderer>().enabled = !rlar.GetComponent<Renderer>().enabled;
                descriptions.text = description_list[5];
                stage = 5;
                confirm_sound.Play();
            }
            else if (stage == 7)
            {
                rservices.GetComponent<Renderer>().enabled = !rservices.GetComponent<Renderer>().enabled;
                descriptions.text = description_list[6];
                stage = 6;
                confirm_sound.Play();
            }
            else if (stage == 8)
            {
                rtrt.GetComponent<Renderer>().enabled = !rtrt.GetComponent<Renderer>().enabled;
                descriptions.text = description_list[7];
                stage = 7;
                confirm_sound.Play();
            }
            else if (stage == 9)
            {
                rsct.GetComponent<Renderer>().enabled = !rsct.GetComponent<Renderer>().enabled;
                descriptions.text = description_list[8];
                stage = 8;
                confirm_sound.Play();
            }
            else if (stage == 10)
            {
                rpixel.GetComponent<Renderer>().enabled = !rpixel.GetComponent<Renderer>().enabled;
                descriptions.text = description_list[9];
                stage = 9;
                confirm_sound.Play();
            }
            else
            {
                error_sound.Play();
            }
        }
        //Debug.Log("Stage: " + stage);
    }
}
