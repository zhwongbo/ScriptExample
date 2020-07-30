using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	private void OnGUI()
	{
		GUILayout.Label("当前游戏经过的时间(秒)：" + Time.time); 
		GUILayout.Label("游戏时间的缩放：" + Time.timeScale); 
		GUILayout.Label("上一帧所消耗的时间：" + Time.deltaTime); 
		GUILayout.Label("固定增量时间：" + Time.fixedTime); 
		GUILayout.Label("上一帧所消耗的固定时间：" + Time.fixedDeltaTime); 
		GUILayout.Label("当前游戏实际经过的时间：" + Time.realtimeSinceStartup);
	}
}
