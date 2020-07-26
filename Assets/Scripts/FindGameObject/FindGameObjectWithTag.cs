using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGameObjectWithTag : MonoBehaviour {

	private const string LogFormat = "FindGameObject With Tag ({0}), result = {1}";
	private GameObject _player;
	private GameObject _otherPlayer;

	// Use this for initialization
	void Start ()
	{
		string toFindGoTag = "Player";
		_player = GameObject.FindWithTag(toFindGoTag);
		Debug.LogFormat(LogFormat, toFindGoTag, (_player == null ? "null" : _player.name));

		toFindGoTag = "Enemy";
		_otherPlayer = GameObject.FindWithTag(toFindGoTag);
		Debug.LogFormat(LogFormat, toFindGoTag, (_otherPlayer == null ? "null" : _otherPlayer.name));
		
//		GameObject[] gos = GameObject.FindGameObjectsWithTag(toFindGoTag);
//		for (int i = 0; i < gos.Length; i++)
//		{
//			Debug.LogFormat("FindGameObject With tags index {0}, name = {1}", i, gos[i].name);
//		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
