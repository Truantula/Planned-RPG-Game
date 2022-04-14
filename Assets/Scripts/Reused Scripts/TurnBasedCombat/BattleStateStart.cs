using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateStart {

	private int first;
	//public BaseEnemy newEnemy = new BaseEnemy ();
	//private StatCalculations statCalculations = new StatCalculations ();
	
	public static void PrepareBattle()
	{
		GameInfo.info.UpdateUI();
		//create enemy
	}
	
	private void UpperHand()
	{
		first = Random.Range(0,15);
		if (first > GameInfo.info.Agility)
		{
			StateMachine.currentState = StateMachine.BattleStates.ENEMYCHOICE;
		}
		if (first <= GameInfo.info.Agility)
		{
			StateMachine.currentState = StateMachine.BattleStates.PLAYERCHOICE;
		}
		
	}
	
	//private void CreateNewEnemy()
	//{
		//do enemy stat adjustments here after making stat calculation script
	//}
	
}
