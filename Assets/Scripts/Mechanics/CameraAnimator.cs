using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraAnimator : MonoBehaviour {

    Camera mainCam;
    
	// Use this for initialization
	void Start () {
        mainCam = Camera.main;
        
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       
        if (Input.GetMouseButtonDown(0))
        {

            if (Physics.Raycast(ray, out hit, 800.0f))
            {
                if (hit.collider.tag == "Winston")
                {
                    mainCam.GetComponent<Animator>().SetBool("animWinston", true);
                    mainCam.GetComponent<Animator>().SetBool("animShroom", false);
                    mainCam.GetComponent<Animator>().SetBool("animHouse", false);
                    mainCam.GetComponent<Animator>().SetBool("animHut", false);
                    mainCam.GetComponent<Animator>().SetBool("animTopDown", false);
                    mainCam.GetComponent<Animator>().SetBool("animLevel1", false);
                    mainCam.GetComponent<Animator>().SetBool("animLevel2", false);
                    Debug.Log("Winston Clicked");
                }
                else if(hit.collider.tag == "Shroom")
                {
                    mainCam.GetComponent<Animator>().SetBool("animWinston", false);
                    mainCam.GetComponent<Animator>().SetBool("animShroom", true);
                    mainCam.GetComponent<Animator>().SetBool("animHouse", false);
                    mainCam.GetComponent<Animator>().SetBool("animHut", false);
                    mainCam.GetComponent<Animator>().SetBool("animTopDown", false);
                    mainCam.GetComponent<Animator>().SetBool("animLevel1", false);
                    mainCam.GetComponent<Animator>().SetBool("animLevel2", false);
                    Debug.Log("Shroom Clicked");
                }
                else if (hit.collider.tag == "House")
                {
                    mainCam.GetComponent<Animator>().SetBool("animWinston", false);
                    mainCam.GetComponent<Animator>().SetBool("animShroom", false);
                    mainCam.GetComponent<Animator>().SetBool("animHouse", true);
                    mainCam.GetComponent<Animator>().SetBool("animHut", false);
                    mainCam.GetComponent<Animator>().SetBool("animTopDown", false);
                    mainCam.GetComponent<Animator>().SetBool("animLevel1", false);
                    mainCam.GetComponent<Animator>().SetBool("animLevel2", false);
                    Debug.Log("House Clicked");
                }
                else if (hit.collider.tag == "Hut")
                {
                    mainCam.GetComponent<Animator>().SetBool("animWinston", false);
                    mainCam.GetComponent<Animator>().SetBool("animShroom", false);
                    mainCam.GetComponent<Animator>().SetBool("animHouse", false);
                    mainCam.GetComponent<Animator>().SetBool("animHut", true);
                    mainCam.GetComponent<Animator>().SetBool("animTopDown", false);
                    mainCam.GetComponent<Animator>().SetBool("animLevel1", false);
                    mainCam.GetComponent<Animator>().SetBool("animLevel2", false);
                    Debug.Log("Hut Clicked");
                }

            }
          
        }
    }
}
