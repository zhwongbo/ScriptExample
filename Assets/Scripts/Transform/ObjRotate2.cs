using UnityEngine;
using System.Collections;

public class ObjRotate2 : MonoBehaviour
{
	public Space space = Space.Self;
	public float speed = 30;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up, speed * Time.deltaTime, space);
	}
}
