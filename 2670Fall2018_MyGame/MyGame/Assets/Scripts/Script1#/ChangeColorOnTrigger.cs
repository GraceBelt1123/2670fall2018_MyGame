using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnTrigger : MonoBehaviour {

	private void OnTriggerEnter(Collider obj)
	{
		obj.GetComponent<SpriteRenderer>().color;
		GetComponent<SpriteRenderer>().color;
	}
}
