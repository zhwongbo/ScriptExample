using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForNull : MonoBehaviour {

	IEnumerator Start ()
	{
		print ("Starting " + Time.time);
		yield return StartCoroutine(WaitAndPrint());
		print ("Done " + Time.time);
	}
	IEnumerator WaitAndPrint ()
	{
		yield return null;
		print ("WaitAndPrint "+ Time.time);
	}
}
