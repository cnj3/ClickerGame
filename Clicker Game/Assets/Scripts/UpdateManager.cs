using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateManager : MonoBehaviour {

	public Click click;
	public UnityEngine.UI.Text itemInfo;
	public float cost;
	public int count = 0;
	public int clickPower;
	public string itemName;
	private float baseCount;

	void Start() {
		baseCost = cost;
	}

	void Update() {
		itemInfo.text = itemName + "\nCost: " + cost + "\nPower: +" + clickPower;
	
	}

	public void PurchasedUpgrade() {
		if (click.gold >= cost) {
			click.gold -= cost;
			count += 1;
			click.goldperclick += clickPower;
			cost = Mathf.Round (baseCost * Mathf.Pow (1.15f, count));
		}
	}



}
