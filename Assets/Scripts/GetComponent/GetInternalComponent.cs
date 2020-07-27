using UnityEngine;

public class GetInternalComponent : MonoBehaviour
{

	private Transform _transform;
	private float _rotateSpeed = 0.3f;
	
	// Use this for initialization
	void Start ()
	{
		_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update ()
	{
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
