using System;
using UnityEngine;
using System.Collections;

public class SmoothDamp : MonoBehaviour {
	public Transform target;
	public float smoothTime = 0.3F;
	private Vector3 force = new Vector3(0, 1000, 0);
	private float yVelocity = 0.0F;
	private Rigidbody _rigidbody;
	private Transform _transform;
	
	void Start()
	{
		_transform = transform;
		_rigidbody = target.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		float newPosition = Mathf.SmoothDamp(_transform.position.y, target.position.y, ref yVelocity, smoothTime);
		_transform.position = new Vector3(_transform.position.x, newPosition, _transform.position.z);
	}


	public void AddForce()
	{
		if (_rigidbody)
		{
			_rigidbody.AddForce(force);
		}
	}
}
