using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayGun : MonoBehaviour {

	public GameObject gun;

	float t ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1")) {
			t = Time.time;

			gun.SetActive (true);
		} 
		else if (Time.time - t >= 5 * Time.deltaTime) 
		{
			gun.SetActive (false);
		}
	}
}
