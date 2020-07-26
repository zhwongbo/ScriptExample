using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class GetComponentByDrag : MonoBehaviour
{

	public ExampleComponent exampleComponent;

	// Use this for initialization
	void Start () 
	{
		if (exampleComponent)
		{
			exampleComponent.DoSomething();
		}
	}
}