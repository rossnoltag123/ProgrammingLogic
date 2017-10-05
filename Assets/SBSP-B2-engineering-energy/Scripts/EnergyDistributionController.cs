using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyDistributionController : MonoBehaviour {

	private EnergyDistributionModel distModel;

	void Awake () {
		distModel = new EnergyDistributionModel ();
	}

	// Use this for initialization
	void Start () {
		//----
		// just testing
		List<EnergyConsumer> consumers = distModel.Consumers;
		foreach (EnergyConsumer consumer in consumers) {
			Debug.Log (consumer.Name);
		}
		//----
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public EnergyDistributionModel DistributionModel { get { return distModel; } }
}
