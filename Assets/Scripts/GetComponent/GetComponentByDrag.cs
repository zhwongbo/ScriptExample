using UnityEngine;

public class GetComponentByDrag : MonoBehaviour
{

	public ExampleComponent exampleComponent;

	// Use this for initialization
	private void Update()
	{
		exampleComponent.DoSomething();
	}
}