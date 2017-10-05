//using System.Collections;
using System.Collections.Generic;
//using UnityEngine;

public class EnergyDistributionModel {

	//

	//list of energy consumers
	private List<EnergyConsumer> consumers;

	//list of observers watching this model
	//public Observer

	public EnergyDistributionModel() {
		//create and populate the list of consumers
		consumers = new List<EnergyConsumer> ();
		consumers.Add (new EnergyConsumer ("Beam", 1.0f));
		consumers.Add (new EnergyConsumer ("Missiles", 3.0f));
		consumers.Add (new EnergyConsumer ("Headlights", 0.3f));
	}
		
	public List<EnergyConsumer> Consumers { get { return consumers; } }
}
