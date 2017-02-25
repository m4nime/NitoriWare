﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouhouSortSortable : MonoBehaviour {
	// Defines an object (usually a touhou)
	// that can be sorted into a category

	// enum of possible categories
	public enum Style {
		Hat,
		Bunny
	}

	// List of all categories which the
	// Sortable belongs to
	public Style[] styles;
    
	public Collider2D hitBox;

	// Tracks the current zone that the object is in
	TouhouSortDropZone currentZone;

	void Start () {
		Collider2D grabBox = GetComponent<Collider2D> ();
		Physics2D.IgnoreCollision(grabBox, hitBox);
	}

	public TouhouSortDropZone GetCurrentZone() {
		return currentZone;
	}

	public void EnterZone(TouhouSortDropZone zone) {
		currentZone = zone;
	}

	public void ExitZone(TouhouSortDropZone zone) {
		if (currentZone == zone) {
			currentZone = null;
		}
	}

}