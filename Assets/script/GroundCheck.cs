﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dwipantara {

public class GroundCheck : MonoBehaviour {

		private Player player;
	// Use this for initialization
	void Start () {
		player = gameObject.GetComponentInParent<Player>();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
			if (col.gameObject.layer == LayerMask.NameToLayer ("Solid")) {
				player.grounded = true;
			}
	}

	void OnTriggerStay2D(Collider2D col)
	{
			if (col.gameObject.layer == LayerMask.NameToLayer ("Solid")) {
				player.grounded = true;
			}
	}

	void OnTriggerExit2D(Collider2D col)
	{
			if (col.gameObject.layer == LayerMask.NameToLayer ("Solid")) {
			player.grounded = false;
			}
	}

}
}
