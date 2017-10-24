using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactorModel{

	public int fuel;
	public int energy;
	public int maxCapacity;


	public ReactorModel(){
		fuel = 0;
		energy = 0;
		maxCapacity = 500;
	}



	public int GetFuel(){
		return fuel;
	}

	public void SetFuel(int fuel){
		this.fuel = fuel;
	}



	public int GetEnergy(){
		return energy;
	}

	public void SetEnergy(int energy){
		this.energy = energy;
	}



	public int GetMaxcapacity(){
		return maxCapacity;
	}

	public void SetMaxcapacity(int maxCapacity){
		this.maxCapacity = maxCapacity;
	}


}
