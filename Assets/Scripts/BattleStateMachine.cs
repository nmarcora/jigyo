﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateMachine : MonoBehaviour {

	public enum PerformAction
	{
		WAIT,
		TAKEACTION,
		PERFORMACTION
	}

	public PerformAction battleStates;

	public List<HandleTurn> PerformList = new List<HandleTurn> ();
	public List<GameObject> HeroesInBattle = new List<GameObject> ();
	public List<GameObject> EnemiesInBattle = new List<GameObject> ();

	// Use this for initialization
	void Start ()
	{
		battleStates = PerformAction.WAIT;
		EnemiesInBattle.AddRange (GameObject.FindGameObjectsWithTag ("Enemy"));
		HeroesInBattle.AddRange (GameObject.FindGameObjectsWithTag ("Hero"));

	}
	
	// Update is called once per frame
	void Update ()
	{
		switch (battleStates)
		{
		case(PerformAction.WAIT):
			if (PerformList.Count > 0)
			{
				battleStates = PerformAction.TAKEACTION;
			}
			break;
		case(PerformAction.TAKEACTION):
			break;
		case(PerformAction.PERFORMACTION):
			break;
		}
	}

	public void CollectActions(HandleTurn input)
	{
		PerformList.Add (input);
	}
}
