using UnityEngine;
using System.Collections;

public class detectStar : MonoBehaviour {

	public int rayDistance = 1000;
	public GameObject thing = null;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		Debug.DrawRay(transform.position, fwd*rayDistance, Color.green);
		RaycastHit hit;

		if (Physics.Raycast(transform.position, fwd, out hit, rayDistance) && hit.transform.gameObject){
			thing = hit.transform.gameObject;
//			if(thing.tag == "star"){
//				thing.GetComponent<Selected>().hitSelected = true;
//			} 

		} else {
			thing = null;
		}
	}
}
