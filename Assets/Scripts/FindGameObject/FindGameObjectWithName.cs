using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGameObjectWithName : MonoBehaviour
{
	private const string LogFormat = "FindGameObject With Name ({0}), result = {1}";
	private GameObject _player;
	private GameObject _otherPlayer;

	public GameObject enemy;
	
	// Use this for initialization
	void Start ()
	{
		string toFindGoName = "LocalPlayer";
		_player = GameObject.Find(toFindGoName);
		Debug.LogFormat(LogFormat, toFindGoName, (_player == null ? "null" : _player.name));

		toFindGoName = "OtherPlayer";
		_otherPlayer = GameObject.Find(toFindGoName);
		Debug.LogFormat(LogFormat, toFindGoName, (_otherPlayer == null ? "null" : _otherPlayer.name));
		
		Debug.LogFormat("FindGameObject {0}", (enemy == null ? "null" : enemy.name));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
