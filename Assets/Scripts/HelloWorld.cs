using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Hello World!");//输出HelloWorld信息到Console视图
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Update Event!");//每一帧输出信息到控制台
	}
}
