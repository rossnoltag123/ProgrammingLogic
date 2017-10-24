using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactorReWork : MonoBehaviour {

	public int fuel;
	public int energy;
	public Text nrgLEVEL;
	public Text storageLevel;
	public Canvas canvas;


	public EnergyStorage energyStorage;
	public CreateEnergy createEnergy;

	// Use this for initialization
	void Start () {
		fuel = 10;
		energy = 0;
		EnergyStorage energyStorage = new EnergyStorage ();
		CreateEnergy createEnergy = new CreateEnergy ();
		InvokeRepeating("Producing", 1.0f, 1.0f);

	}

	// Update is called once per frame
	void Update () {
		CheckEnergy ();
		CheckingStorage ();

	}

	public void Producing(){ // Create energy where 1x energy unit will be equivalent to 100x sun energy units

		energy = energy + fuel; // Energy will be quivalent to 100 sun energy units 
		//createEnergy.ShowTransfer();
	}

	public void CheckEnergy(){

		nrgLEVEL.text = "Energy level: " + energy;
	}

	public void CheckingStorage(){

		if (energy >= 500) {
//			energyStorage.GetOkToDistribute (true);

			energyStorage.SetCurrentCapacity (energyStorage.GetCurrentCapacity() + 500);
			storageLevel.text = "Energy storage: " + energyStorage.GetCurrentCapacity();

			energy -= 500;
		}

		if (energyStorage.GetCurrentCapacity() >= 500) {
			energyStorage.SetOkToDistribute(true) ;
		}
	}





}
