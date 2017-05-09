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

    public UnityEngine.UI.Text descriptions;

    int stage;

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
                descriptions.text = "Stage 1: Middle Muon Barrel";
                stage = 1;
            }
            else if (stage == 1)
            {
                muonBarrelmid.GetComponent<Renderer>().enabled = !muonBarrelmid.GetComponent<Renderer>().enabled;
                descriptions.text = "Stage 2: Muon Toroids Barrel";
                stage = 2;
            }
            else if (stage == 2)
            {
                foreach (Transform child in muontoroidsbarrel.transform)
                {
                    child.GetComponent<Renderer>().enabled = !child.GetComponent<Renderer>().enabled;
                }
                descriptions.text = "Stage 3: Inner Muon Barrel";
                stage = 3;
            }
            else if (stage == 3)
            {
                muonBarrelin.GetComponent<Renderer>().enabled = !muonBarrelin.GetComponent<Renderer>().enabled;
                descriptions.text = "Stage 4: RTile";
                stage = 4;
            }
            else if (stage == 4)
            {
                rtile.GetComponent<Renderer>().enabled = !rtile.GetComponent<Renderer>().enabled;
                descriptions.text = "Stage 5: RLAr";
                stage = 5;
            }
            else if (stage == 5)
            {
                rlar.GetComponent<Renderer>().enabled = !rlar.GetComponent<Renderer>().enabled;
                descriptions.text = "Stage 6: RServices";
                stage = 6;
            }
            else if (stage == 6)
            {
                rservices.GetComponent<Renderer>().enabled = !rservices.GetComponent<Renderer>().enabled;
                descriptions.text = "Stage 7: TRT\nTransition Radiation Tracker(RTR) is the \noutermost of the three tracking subsystems \nof the ATLAS Inner Detector.";
                stage = 7;
            }
            else if (stage == 7)
            {
                rtrt.GetComponent<Renderer>().enabled = !rtrt.GetComponent<Renderer>().enabled;
                descriptions.text = "Stage 8: SCT";
                stage = 8;
            }
            else if (stage == 8)
            {
                rsct.GetComponent<Renderer>().enabled = !rsct.GetComponent<Renderer>().enabled;
                descriptions.text = "Stage 9: RPixel";
                stage = 9;
            }
            else if (stage == 9)
            {
                rpixel.GetComponent<Renderer>().enabled = !rpixel.GetComponent<Renderer>().enabled;
                descriptions.text = "Stage 10: Beam Pipe";
                stage = 10;
            }
        }
        else if (Input.GetKeyDown("joystick button 1"))
        {
            if (stage == 1)
            {
                muonBarrelout.GetComponent<Renderer>().enabled = !muonBarrelout.GetComponent<Renderer>().enabled;
                descriptions.text = "Stage 0: Exterior Muon Barrel";
                stage = 0;
            }
            else if (stage == 2)
            {
                muonBarrelmid.GetComponent<Renderer>().enabled = !muonBarrelmid.GetComponent<Renderer>().enabled;
                descriptions.text = "Stage 1: Middle Muon Barrel";
                stage = 1;
            }
            else if (stage == 3)
            {
                foreach (Transform child in muontoroidsbarrel.transform)
                {
                    child.GetComponent<Renderer>().enabled = !child.GetComponent<Renderer>().enabled;
                }
                descriptions.text = "Stage 2: Muon Toroids Barrel";
                stage = 2;
            }
            else if (stage == 4)
            {
                muonBarrelin.GetComponent<Renderer>().enabled = !muonBarrelin.GetComponent<Renderer>().enabled;
                descriptions.text = "Stage 3: Inner Muon Barrel";
                stage = 3;
            }
            else if (stage == 5)
            {
                rtile.GetComponent<Renderer>().enabled = !rtile.GetComponent<Renderer>().enabled;
                descriptions.text = "Stage 4: RTile";
                stage = 4;
            }
            else if (stage == 6)
            {
                rlar.GetComponent<Renderer>().enabled = !rlar.GetComponent<Renderer>().enabled;
                descriptions.text = "Stage 5: RLAr";
                stage = 5;
            }
            else if (stage == 7)
            {
                rservices.GetComponent<Renderer>().enabled = !rservices.GetComponent<Renderer>().enabled;
                descriptions.text = "Stage 6: RServices";
                stage = 6;
            }
            else if (stage == 8)
            {
                rtrt.GetComponent<Renderer>().enabled = !rtrt.GetComponent<Renderer>().enabled;
                descriptions.text = "Stage 7: TRT\nTransition Radiation Tracker(RTR) is the outermost of the \nthree tracking subsystems of the ATLAS Inner Detector.";
                stage = 7;
            }
            else if (stage == 9)
            {
                rsct.GetComponent<Renderer>().enabled = !rsct.GetComponent<Renderer>().enabled;
                descriptions.text = "Stage 8: SCT";
                stage = 8;
            }
            else if (stage == 10)
            {
                rpixel.GetComponent<Renderer>().enabled = !rpixel.GetComponent<Renderer>().enabled;
                descriptions.text = "Stage 9: RPixel";
                stage = 9;
            }
        }
        //Debug.Log("Stage: " + stage);
    }
}
