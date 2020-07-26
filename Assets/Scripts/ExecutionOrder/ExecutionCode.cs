using UnityEngine;

public class ExecutionCode : MonoBehaviour {
	private void Awake()
	{
		Debug.Log("Awake");
	}

	// Use this for initialization
	void Start () {
		Debug.Log("Start");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Update");
	}

	private void LateUpdate()
	{
		Debug.Log("LateUpdate");
	}

	private void FixedUpdate()
	{
		Debug.Log("FixedUpdate");
	}
}
