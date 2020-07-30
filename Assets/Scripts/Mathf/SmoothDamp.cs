using System;
using UnityEngine;
using System.Collections;

public class SmoothDamp : MonoBehaviour {
	public Transform target;
	public float smoothTime = 0.3F;
	private Vector3 force = new Vector3(0, 1000, 0);
	private float yVelocity = 0.0F;
	private Transform _targetTransform;
	private Transform _transform;
	
	void Start()
	{
		_transform = transform;
		_targetTransform = target.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		float newPosition = Mathf.SmoothDamp(_transform.position.y, target.position.y, ref yVelocity, smoothTime);
		_transform.position = new Vector3(_transform.position.x, newPosition, _transform.position.z);
	}


	public void MoveToRight()
	{
		if (_targetTransform)
		{
			_targetTransform.position -= Vector3.up * 5;
		}
	}

	public void MoveToLeft()
	{
		_targetTransform.position += Vector3.up * 5;
	}
}
