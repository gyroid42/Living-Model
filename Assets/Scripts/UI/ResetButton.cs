using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour {
    Camera mainCam;
    public Button button;
	// Use this for initialization
	void Start () {
        mainCam = Camera.main;
        button.onClick.AddListener(OnClick);
	}

    // Update is called once per frame
    void OnClick()
    {
        mainCam.GetComponent<Animator>().SetBool("animWinston", false);
        mainCam.GetComponent<Animator>().SetBool("animShroom", false);
        mainCam.GetComponent<Animator>().SetBool("animHouse", false);
        mainCam.GetComponent<Animator>().SetBool("animHut", false);
        mainCam.GetComponent<Animator>().SetBool("animTopDown", true);
        mainCam.GetComponent<Animator>().SetBool("animLevel1", false);
        mainCam.GetComponent<Animator>().SetBool("animLevel2", false);

        Debug.Log("Reset Button Clicked");
        
    }
}
