﻿using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	public Sprite grassEdgeSprite;
	//public ParticleSystem collapseParticles;

	SpriteRenderer spriteRend;

	public IntVector2 tileIndex = new IntVector2();


	Fault fault;

	bool collapsed = false;
	// Use this for initialization
	void Awake () {
		fault = null;
		spriteRend = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetEdgeSprite(){
		spriteRend.sprite = grassEdgeSprite;
	}

	public void AddFault(Fault _fault){
		fault = _fault;
	}

	public bool HasFault(){
		return fault != null;
	}
    public bool HasMainFault()
    {
        return true;        
    }

	public Fault GetFault(){
		return fault;
	}

	public void Collapse(){
		collapsed = true;

		spriteRend.enabled = false;
		if (HasFault ()) {
			fault.Collapse ();
		}

	}

	public bool HasCollapsed(){
		return collapsed;
	}
}
