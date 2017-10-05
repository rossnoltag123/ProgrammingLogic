using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyDistributionView : MonoBehaviour {

	public Text connectedConsumers;

	private EnergyDistributionModel distModel;

	void Awake() {
		EnergyDistributionController distController = GetComponentInParent<EnergyDistributionController> ();
		distModel = distController.DistributionModel;
		Debug.Log (distModel.ToString());
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
