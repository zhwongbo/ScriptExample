using UnityEngine;
using System.Collections;

public class ObjRotate : MonoBehaviour
{

	public float speed = 30;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Time.deltaTime表示距上一次调用所用的时间。
		transform.Rotate(Vector3.up * Time.deltaTime * speed); 

	}
}