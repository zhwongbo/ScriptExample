using UnityEngine;
using System.Collections;

public class ObjTranslate : MonoBehaviour
{

	public float speed = 1;
	private Transform _transform;
	
	// Use this for initialization
	void Start ()
	{
		_transform = transform;
	}
	
	// Update is called once per frame
	void Update () {

		_transform.Translate(Vector3.left * Time.deltaTime* speed); 
	}
}
