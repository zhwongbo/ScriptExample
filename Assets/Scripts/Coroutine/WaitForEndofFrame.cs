using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForEndofFrame : MonoBehaviour
{
	public GameObject ball;
	public GameObject player;
	private Animator _playerAnimator;
	private string _bindName = "EthanRightHandMiddle4";

	// Use this for initialization
	void Start ()
	{
		_playerAnimator = player.GetComponent<Animator>();
		//AnimatorUtility.OptimizeTransformHierarchy(player, new string[]{});
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.F4))
		{
			BindBallToPlayer();
		}
	}


	public void BindBallToPlayer()
	{
		var go = GameObject.Instantiate(ball);
		//AnimatorUtility.DeoptimizeTransformHierarchy(player);
		
		AnimatorUtility.OptimizeTransformHierarchy(player, new string[]{});

		Transform[] transforms = player.GetComponentsInChildren<Transform>(true);
		for (int i = 0; i < transforms.Length; i++)
		{
			if (transforms[i].name.Equals(_bindName))
			{
				go.transform.SetParent(transforms[i], false);
				go.transform.localPosition = Vector3.zero;
				break;
			}
		}
	}
}
