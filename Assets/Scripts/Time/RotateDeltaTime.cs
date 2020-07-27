using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDeltaTime : MonoBehaviour
{
	public float speed;
	private Transform _transform;
	
	// Use this for initialization
	void Start ()
	{
		_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (_transform)
		{
			_transform.Rotate(Vector3.up, speed * Time.deltaTime);
		}
	}
}
