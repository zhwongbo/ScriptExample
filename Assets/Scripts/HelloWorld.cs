using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {
	private void Awake()
	{
		Debug.Log("Hello World!  Awake "+  Time.frameCount);
	}

	// Use this for initialization
	void Start () {
		Debug.Log("Hello World! Start  "  +  Time.frameCount);//输出HelloWorld信息到Console视图
	}


	private void OnEnable()
	{
		Debug.Log("Hello World!  OnEnable");
	}


	private void OnDisable()
	{
		Debug.Log("Hello World!  OnDisable");
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log ("Update Event!");//每一帧输出信息到控制台
	}
}
