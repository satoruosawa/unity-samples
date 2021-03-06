using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour {
	[SerializeField] Vector3 position = Vector3.zero;

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.position = position;
	}
}