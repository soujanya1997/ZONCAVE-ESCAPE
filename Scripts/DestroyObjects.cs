using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;
using UnityEngine.UI ;

public class DestroyObjects : MonoBehaviour {

	public bool KeyFound ;
	public Text healthText ;
	public float Health = 100f;
	private Vector3 t; 
	public GameObject key ;
	// Use this for initialization
	void Start () {
		t = transform.position;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Key")) 
		{
			KeyFound = true;
			key = other.gameObject;
			other.gameObject.SetActive(false);
		}

		if (other.CompareTag ("Crystal")) 
		{
			if(Health + 5 <= 100)
				Health += 5;
			healthText.text = ((int)Health).ToString();
			Destroy (other.gameObject);
		}
	}

	void OnTriggerStay(Collider other)
	{
		if (other.CompareTag ("Zombie") && Health > 1 && !other.gameObject.GetComponent<EnemyFollowPlayer>().zombieAnim.GetBool("dead")) 
		{
			Health -= Time.deltaTime ;
			healthText.text = ((int)Health).ToString();
			print ((int)Health);
		}
	}

	// Update is called once per frame
	void Update () {

		if (Health < 1) 
		{
			Death ();
		}
	}

	void Death()
	{

	}
}
