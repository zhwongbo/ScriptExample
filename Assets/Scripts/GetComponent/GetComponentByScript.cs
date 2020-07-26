using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentByScript : MonoBehaviour
{

	private ExampleComponent _exampleComponent;
	
	// Use this for initialization
	void Start ()
	{
		_exampleComponent = GetComponent<ExampleComponent>();
		if (_exampleComponent)
		{
			_exampleComponent.DoSomething();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
