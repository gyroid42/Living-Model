using UnityEngine;
using System.Collections;

public class CameraChange : MonoBehaviour {

    public Vector3 top_down_pos = new Vector3(1.0f, 122.0f, 8.0f);
    public Vector3 look_at_pos = new Vector3(0.0f, 17.9f, -58.7f);
    public Vector3 top_down_rotation_degrees = new Vector3(90.0f, -180.0f, -180.0f);
    public Vector3 look_at_rotation_degrees = new Vector3(2.86f, -360.0f, -360.0f);
    public AudioClip audio_sound;
    public AudioSource audio_source;
    private Quaternion top_down_rotation;
    private Quaternion look_at_rotation;
    private bool cam_state = true;//true for top down, false for look at
    Camera maincam;
	// Use this for initialization
	void Start () {
        maincam = Camera.main;//point unity to main camera object
        //cast degrees to Quaternion
        top_down_rotation = Quaternion.Euler(top_down_rotation_degrees);
        look_at_rotation = Quaternion.Euler(look_at_rotation_degrees);

        audio_source.clip = audio_sound;
	}

    void OnMouseDown()
    {
        if(cam_state)
        {
            maincam.transform.position = look_at_pos;//transfrom the cam position to look at object clicked
            maincam.transform.rotation = look_at_rotation;//rotate the camera to look at object picked
            audio_source.Play();
            cam_state = false;
        }
        else if(!cam_state)
        {
            maincam.transform.position = top_down_pos;
            maincam.transform.rotation = top_down_rotation;
            cam_state = true;
        }
       
        
    }

	
	// Update is called once per frame
	
}
