using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateEnemyChoice {

	private GameObject[] enemies;
	public static GameObject actingEnemy;
	private List<BaseAbility> randomApplicableEnemyMoves = new List<BaseAbility>();
	private List<GameObject> aliveEnemies = new List<GameObject>();
	private EnemyBattleCalculations enemyBattleCalcScript = new EnemyBattleCalculations ();

	public void EnemyAction()
	{
		//choose ability, calculate damage, end turn
		aliveEnemies.Clear();
		enemies = GameObject.FindGameObjectsWithTag("enemy");
		foreach (GameObject enemy in enemies)
		{
			if (enemy.GetComponent<CreateEnemy>().health.CurrentVal > 0)
			{
				aliveEnemies.Add(enemy);
			}
		}		
		foreach (GameObject activeEnemy in aliveEnemies)
		{
			randomApplicableEnemyMoves.Clear();
			//find baseenemy script per enemy, from there enemyMoves
			foreach (BaseAbility move in activeEnemy.GetComponent<BaseEnemy>().enemyMoves)
			{
				if (move.WPCost <= activeEnemy.GetComponent<CreateEnemy>().willpower.CurrentVal)
				{
					randomApplicableEnemyMoves.Add(move);
				}
			}
			int rand = Random.Range(0,randomApplicableEnemyMoves.Count);
			StateMachine.characterUsedAbility = randomApplicableEnemyMoves[rand];
			actingEnemy = activeEnemy;
			EnemySelect(StateMachine.characterUsedAbility);
			activeEnemy.GetComponent<CreateEnemy>().willpower.CurrentVal -= StateMachine.characterUsedAbility.WPCost;
			enemyBattleCalcScript.EnemyCalculateTotalDamage(StateMachine.characterUsedAbility);
		}
		StateMachine.enemyCompleteTurn = true;
	}
	
	private void EnemySelect(BaseAbility usedAbility)
	{
		GameObject BattleManager = GameObject.Find("BattleManager");
		BattleGUI battleGUI = BattleManager.GetComponent<BattleGUI>();
		if (usedAbility.AbilityTarget == "allEnemy")
		{
			GameObject createPlayer = GameObject.Find("CreatePlayer");
			battleGUI.targets.Add(createPlayer);
		}
		else if (usedAbility.AbilityTarget == "oneEnemy")
		{
			GameObject createPlayer = GameObject.Find("CreatePlayer");
			battleGUI.targets.Add(createPlayer);
		}
		else if (usedAbility.AbilityTarget == "self")
		{
			battleGUI.targets.Add(actingEnemy);
		}
	}

}
