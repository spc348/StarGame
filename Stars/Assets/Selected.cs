﻿using UnityEngine;
using System.Collections;

public class Selected : MonoBehaviour {

	public bool hitSelected = false;
	public string currentStar;
	public AudioClip hoverSound;
	public AudioClip selectSound;
	private detectStar DetectStar;
	public bool preparedForSelect = false;
	public bool isSelected = false;
	public Vector3 originalScale;
	public Vector3 highlightScale;

	// Use this for initialization
	void Start () {
		DetectStar = Camera.main.gameObject.GetComponent<detectStar>();
		originalScale = transform.localScale;
		highlightScale  = originalScale*2;
	}
	
	// Update is called once per frame
	void Update () {

		//Establish that the star the Ray is hitting is the star this script is on
		currentStar = DetectStar.thing.name;
		if(currentStar==this.gameObject.name){
			Color selectedColor = new Color(0, 255, 0) * Time.deltaTime;
			renderer.material.color = selectedColor;
//			transform.localScale = new Vector3(2F, 2F, 2F);
			transform.localScale = highlightScale;

			preparedForSelect = true;
			Debug.Log(preparedForSelect);'
			Debug.Log("hell");
		} else {
			Color otherColor = new Color(255, 255, 255) * Time.deltaTime;
			renderer.material.color = otherColor;
			transform.localScale = originalScale;
		}

		if(preparedForSelect == true && Input.GetKey(KeyCode.J)) {
			audio.PlayOneShot(selectSound,1);
			isSelected = true;
		}
	
	}

//		if(hitSelected == true) { 
//			
//		}
	}



