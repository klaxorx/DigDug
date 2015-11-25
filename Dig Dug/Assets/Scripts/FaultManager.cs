﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FaultManager : MonoBehaviour {

	public GameObject faultPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CreateCracks(Tile[] tilesToAddCracks){
		for (int i = 0; i<tilesToAddCracks.Length; i++) {
			GameObject newFault = Instantiate (faultPrefab);
			newFault.transform.SetParent(tilesToAddCracks[i].transform);
			newFault.transform.localPosition = Vector3.zero;
			Fault fault = newFault.GetComponent<Fault>();
			fault.FadeIn();
		}



	}
}