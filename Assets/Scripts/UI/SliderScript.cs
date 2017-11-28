using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {
    public GameObject GameObject;
    Color32 color;
    byte sliderVal2;
	// Use this for initialization
	void Start () {

        //GameObject = GameObject.FindWithTag("Cube");
	}
	
	// Update is called once per frame
	void Update () {
        float sliderVal = sliderVal = this.GetComponent<Slider>().value;
        sliderVal2 = (byte)(sliderVal * 255);
        color = new Color32(sliderVal2, 10, 10, 255);
        GameObject.GetComponent<Renderer>().material.color = color;
	}
}
