using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class GetComponentFindProfiler : MonoBehaviour
{
	public GameObject exampleComponent1Go;
	public GameObject exampleComponent2Go;

	private ExampleComponent _exampleComponent1;
	private ExampleComponent _exampleComponent2;
	
	// Use this for initialization
	void Start ()
	{
		_exampleComponent1 = exampleComponent1Go.GetComponent<ExampleComponent>();
	}
	
	// Update is called once per frame
	void Update () {
		
		Profiler.BeginSample("ExampleComponent1");
		_exampleComponent1.DoSomething();
		Profiler.EndSample();
		
		Profiler.BeginSample("ExampleComponent2");
		_exampleComponent2 = exampleComponent2Go.GetComponent<ExampleComponent>();
		_exampleComponent2.DoSomething();
		Profiler.EndSample();
		
	}
}
