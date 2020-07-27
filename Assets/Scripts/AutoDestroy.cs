using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour {

	[Range(3, 10)]
	public float interval;

	private float startTime;
	
	// Use this for initialization
	void Start ()
	{
		startTime = Time.realtimeSinceStartup;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.realtimeSinceStartup - startTime >= interval)
		{
			GameObject.Destroy(gameObject);
		}
	}
}
