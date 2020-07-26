using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInternalComponent : MonoBehaviour
{

	private Transform _transform;
	
	// Use this for initialization
	void Start ()
	{
		_transform = this.transform;
		_transform.Rotate(Vector3.up, 30);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
