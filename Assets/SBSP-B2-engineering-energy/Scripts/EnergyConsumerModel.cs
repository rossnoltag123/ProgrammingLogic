//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

public class EnergyConsumerModel {

	private string name;

	// no. of units of energy consumed per time unit
	// during normal operation - currEnergyMultiplier = 1.0f
	private float baseEnergyConsumption;

	// < 1.0f - underperforming
	// = 1.0f - normal operation
	// > 1.0f - overdrive
	private float currentEnergyMultiplier = 1.0f;


	private const float MAX_ENERGY_OVERDRIVE = 2.0f;

	// ---- to add later -----
	//private float currCoolantLevel = 0.0f;
	//private const float MAX_COOLANT_LEVEL = 1.0f;
	//public float heatLevel;
	//--

	public EnergyConsumerModel(string name, float baseEnergyConsumption) {
		this.name = name;
		this.baseEnergyConsumption = baseEnergyConsumption;
	}

	public string GetName { get { return name; } }

	public float GetCurrentEnergyConsumption() {
		return currentEnergyMultiplier * baseEnergyConsumption;
	}

	public float GetCurrentEnergyMultiplier() {
		return currentEnergyMultiplier;
	}

	public bool SetCurrentEnergyMultiplier(float multiplier) {
		if (multiplier <= MAX_ENERGY_OVERDRIVE) {
			currentEnergyMultiplier = multiplier;
			return true;
		} else {
			currentEnergyMultiplier = MAX_ENERGY_OVERDRIVE;
			return false;
		}
	}
}
