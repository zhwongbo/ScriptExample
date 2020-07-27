using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScaleController : MonoBehaviour
{

	public AnimationCurve curve;
	private float _time;
	private float _scale;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		_time += Time.deltaTime;
		_scale = curve.Evaluate(_time);
		Time.timeScale = _scale;
	}
}
