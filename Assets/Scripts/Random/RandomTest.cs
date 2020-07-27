using UnityEngine;

public class RandomTest : MonoBehaviour {

	public GameObject[] gos;

	[Range(2, 10)]
	public float interval;

	private float _lastTime;

	private Transform _trans;
	
	// Use this for initialization
	void Start ()
	{
		_lastTime = Time.realtimeSinceStartup;
		_trans = transform;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Time.realtimeSinceStartup - _lastTime >= interval)
		{
			if (gos.Length > 0)
			{
				int index = Random.Range(0, gos.Length);
				var go = Instantiate(gos[index]);

				MeshRenderer render = go.GetComponent<MeshRenderer>();
				render.material.color = new Color(Random.value, Random.value, Random.value, 1);
				
				go.SetActive(true);
				go.transform.position = _trans.position;
			}

			_lastTime = Time.realtimeSinceStartup;
		}
	}
}
