using UnityEngine;
using System.Collections;

public class CameraChange : MonoBehaviour {

    public AudioClip audio_sound;
    public AudioSource audio_source;
    //public mainCam.GetComponent<Animator>() anim;
    private bool cam_state = true;//true for top down, false for look at
    Camera mainCam;
	// Use this for initialization
	void Start () {
        mainCam = Camera.main;//point unity to main camera object
        //cast degrees to Quaternion
        audio_source.clip = audio_sound;
	}

    void OnMouseDown()
    {
      
        if (cam_state)
        {
            mainCam.GetComponent<Animator>().SetBool("animWinston", true);
            audio_source.Play();
            cam_state = false;
        }
       
       else if(!cam_state)
        { 
            mainCam.GetComponent<Animator>().SetBool("animWinston", false);
            cam_state = true;
        }
       
     
    }

    // Update is called once per frame

}
