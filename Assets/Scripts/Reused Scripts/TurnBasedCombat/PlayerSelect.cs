using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelect {

	public GameObject[] possibleTargets;
	public GameObject arrow;
	public GameObject nullTarget;
	public GameObject selfTarget;
	public GameObject characterPanel;
	//public bool singleTarget;
	int index = 0;
	//private BaseAbility characterUsedAbility;

	public void ChooseTarget(BaseAbility usedAbility)
	{
		GameObject BattleManager = GameObject.Find("BattleManager");
		BattleGUI battleGUI = BattleManager.GetComponent<BattleGUI>();
		if (usedAbility.AbilityTarget == "allEnemy")
		{
			StateMachine.singleTarget = false;
			foreach (GameObject targetAll in GameObject.FindGameObjectsWithTag("enemy")) 
			{
				battleGUI.targets.Add(targetAll);
			}
			foreach (GameObject target in battleGUI.targets)
			{
				arrow = target.transform.Find("SelectArrow").gameObject;
				arrow.GetComponent<Image>().enabled = true;
				arrow.GetComponent<Animator>().enabled = true;
			}
		}
		else if (usedAbility.AbilityTarget == "oneEnemy")
		{
			StateMachine.singleTarget = true;
		}
		else if (usedAbility.AbilityTarget == "self")
		{
			selfTarget = GameObject.FindGameObjectWithTag("Player");
			characterPanel = selfTarget.transform.Find("CharacterPanel").gameObject;
			arrow = characterPanel.transform.Find("SelectArrow").gameObject;
			arrow.GetComponent<Image>().enabled = true;
			arrow.GetComponent<Animator>().enabled = true;
			GameObject createPlayer = GameObject.Find("CreatePlayer");
			//CreateCharacter createCharacter = createPlayer.GetComponent<CreateCharacter>();
			battleGUI.targets.Add(createPlayer);
		}
		StateMachine.currentState = StateMachine.BattleStates.CALCDAMAGE;
		StateMachine.moved = true;
		//StateMachine.currentState = StateMachine.BattleStates.CALCDAMAGE;
	}
	
	public void Update()
	{
		GameObject BattleManager = GameObject.Find("BattleManager");
		BattleGUI battleGUI = BattleManager.GetComponent<BattleGUI>();
		possibleTargets = GameObject.FindGameObjectsWithTag("enemy");

			if (Input.GetKeyDown(KeyCode.DownArrow))
				{
					if (index < possibleTargets.Length - 1)
					{
						index ++;
						foreach (GameObject possibleTarget in possibleTargets)
						{
							nullTarget = possibleTarget.transform.Find("SelectArrow").gameObject;
							nullTarget.GetComponent<Image>().enabled = false;
							nullTarget.GetComponent<Animator>().enabled = false;
						}
					}
				}
				if (Input.GetKeyDown(KeyCode.UpArrow))
				{
					if (index > 0)
					{
						index --;
						foreach (var possibleTarget in possibleTargets)
						{
							nullTarget = possibleTarget.transform.Find("SelectArrow").gameObject;
							nullTarget.GetComponent<Image>().enabled = false;
							nullTarget.GetComponent<Animator>().enabled = false;
						}
					}
				}
				switch (index)
				{
					case (0):
					arrow = possibleTargets[0].transform.Find("SelectArrow").gameObject;
					arrow.GetComponent<Image>().enabled = true;
					arrow.GetComponent<Animator>().enabled = true;
					battleGUI.targets.Clear();
					battleGUI.targets.Add(possibleTargets[0]);
						break;
					case (1):
					arrow = possibleTargets[1].transform.Find("SelectArrow").gameObject;
					arrow.GetComponent<Image>().enabled = true;
					arrow.GetComponent<Animator>().enabled = true;
					battleGUI.targets.Clear();
					battleGUI.targets.Add(possibleTargets[1]);
						break;
					case (2):
					arrow = possibleTargets[2].transform.Find("SelectArrow").gameObject;
					arrow.GetComponent<Image>().enabled = true;
					arrow.GetComponent<Animator>().enabled = true;
					battleGUI.targets.Clear();
					battleGUI.targets.Add(possibleTargets[2]);
						break;
					//set active/inactive images and animators
				}
			StateMachine.moved = true;
	}
	
}