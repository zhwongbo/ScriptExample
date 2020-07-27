using UnityEngine;

public class ExampleComponent : MonoBehaviour
{

	private Transform _transform;
	private float _rotateSpeed = 0.3f;
	
	// Use this for initialization
	void Start ()
	{
		_transform = transform;
		DoSomething();
	}
	
	public void DoSomething()
	{
		if (_transform)
		{
			_transform.Rotate(Vector3.up, _rotateSpeed);
		}
	}
}