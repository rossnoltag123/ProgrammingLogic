using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	public Transform start;

	void OnTriggerEnter2D(Collider2D hit){

		if(hit.CompareTag("plasma")){

			hit.transform.position = start.position;
		}
	}

}