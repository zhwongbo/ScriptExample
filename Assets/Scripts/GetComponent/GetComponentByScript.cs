using UnityEngine;

public class GetComponentByScript : MonoBehaviour
{

	private ExampleComponent _exampleComponent;

	// Use this for initialization
	void Start()
	{
		_exampleComponent = GetComponent<ExampleComponent>();
	}

	// Update is called once per frame
	void Update()
	{
		if (_exampleComponent)
		{
			_exampleComponent.DoSomething();
		}
	}
}