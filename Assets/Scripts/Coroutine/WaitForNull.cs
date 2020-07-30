using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForNull : MonoBehaviour {

	IEnumerator Start ()
	{
		print ("Starting " + Time.frameCount);
		yield return StartCoroutine(WaitAndPrint());
		print ("Done " + Time.frameCount);
	}
	IEnumerator WaitAndPrint ()
	{
		yield return 5000;
		print ("WaitAndPrint "+ Time.frameCount);
	}
}
