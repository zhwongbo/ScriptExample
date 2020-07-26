using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleComponent : MonoBehaviour
{

	private Transform _transform;
	
	// Use this for initialization
	void Start ()
	{
		_transform = transform;
		DoSomething();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DoSomething()
	{
		if (_transform)
		{
			_transform.Rotate(Vector3.up, 30);
		}
	}
}