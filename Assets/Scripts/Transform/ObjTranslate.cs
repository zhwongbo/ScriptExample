using UnityEngine;
using System.Collections;

public class ObjTranslate : MonoBehaviour
{

	public float speed = 1;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(Vector3.left * Time.deltaTime* speed); 
	}
}
