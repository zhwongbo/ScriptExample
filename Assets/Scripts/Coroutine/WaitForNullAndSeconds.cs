using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForNullAndSeconds : MonoBehaviour {

	void Start()
	{
		StartCoroutine(Coroutine3());
		StartCoroutine(Coroutine2());
		StartCoroutine(Coroutine1());
	}
	
	IEnumerator Coroutine1()
	{
		yield return null;
		Debug.Log("Coroutine1 function");
	}
	IEnumerator Coroutine2()
	{
		yield return null;
		Debug.Log("Coroutine2 function");
	}

	IEnumerator Coroutine3()
	{
		yield return new WaitForSeconds(0.000001f);
		Debug.Log("Coroutine3 function");
	}
}
