using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleGUI : MonoBehaviour {

	public List<GameObject> targets;
	public GameObject arrow;
	private PlayerSelect playerSelectScript = new PlayerSelect ();
	public GUIStyle style;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI()
	{
		if(StateMachine.currentState == StateMachine.BattleStates.PLAYERCHOICE)
		{
			DisplayPlayerChoice();
			//choose to attack, defend, run, check, etc first
		}
		//move buttons, enemy health, enemy status, player info
	}
	
	private void DisplayPlayerChoice()
	{
		GameObject createPlayer = GameObject.Find("CreatePlayer");
		CreateCharacter createCharacter = createPlayer.GetComponent<CreateCharacter>();
		if (GUI.Button (new Rect (Screen.width - 250, Screen.height - 50, 100, 30), GameInfo.characterMoveOne.AbilityName))
		{
			StateMachine.characterUsedAbility = GameInfo.characterMoveOne;
			playerSelectScript.ChooseTarget(StateMachine.characterUsedAbility);
		}
		
		if (createCharacter.willpower.CurrentVal >= GameInfo.characterMoveTwo.WPCost)
		{
			if (GUI.Button (new Rect (Screen.width - 150, Screen.height - 50, 100, 30), GameInfo.characterMoveTwo.AbilityName))
			{
				StateMachine.characterUsedAbility = GameInfo.characterMoveTwo;
				playerSelectScript.ChooseTarget(StateMachine.characterUsedAbility);
			}
		}
		else
		{
			if (GUI.Button (new Rect (Screen.width - 150, Screen.height - 50, 100, 30), GameInfo.characterMoveTwo.AbilityName, style))
			{
				Debug.Log("Not enough WP");
			}
		}
		
		if(GameInfo.characterMoveThree != null)
		{
			if (createCharacter.willpower.CurrentVal >= GameInfo.characterMoveThree.WPCost)
			{
				if (GUI.Button (new Rect (Screen.width - 150, Screen.height - 150, 100, 30), GameInfo.characterMoveThree.AbilityName))
				{
					StateMachine.characterUsedAbility = GameInfo.characterMoveThree;
					playerSelectScript.ChooseTarget(StateMachine.characterUsedAbility);
				}
			}
			else
			{
				if (GUI.Button (new Rect (Screen.width - 150, Screen.height - 150, 100, 30), GameInfo.characterMoveThree.AbilityName, style))
				{
					Debug.Log("Not enough WP");
				}
			}
		}
		
		if(GameInfo.characterMoveFour != null)
		{
			if (createCharacter.willpower.CurrentVal >= GameInfo.characterMoveFour.WPCost)
			{
				if (GUI.Button (new Rect (Screen.width - 250, Screen.height - 150, 100, 30), GameInfo.characterMoveFour.AbilityName))
				{
					StateMachine.characterUsedAbility = GameInfo.characterMoveFour;
					playerSelectScript.ChooseTarget(StateMachine.characterUsedAbility);
				}
			}
			else
			{
				if (GUI.Button (new Rect (Screen.width - 250, Screen.height - 150, 100, 30), GameInfo.characterMoveFour.AbilityName, style))
				{
					Debug.Log("Not enough WP");
				}
			}
		}
		
		if(GameInfo.characterMoveFive != null)
		{
			if (createCharacter.willpower.CurrentVal >= GameInfo.characterMoveFive.WPCost)
			{
				if (GUI.Button (new Rect (Screen.width - 350, Screen.height - 50, 100, 30), GameInfo.characterMoveFive.AbilityName))
				{
					StateMachine.characterUsedAbility = GameInfo.characterMoveFive;
					playerSelectScript.ChooseTarget(StateMachine.characterUsedAbility);
				}
			}
			else
			{
				if (GUI.Button (new Rect (Screen.width - 350, Screen.height - 50, 100, 30), GameInfo.characterMoveFive.AbilityName, style))
				{
					Debug.Log("Not enough WP");
				}
			}
		}

		/*if (GUI.Button (new Rect (Screen.width - 150, Screen.height - 50, 100, 30), GameInfo.characterMoveTwo.AbilityName))
		{
			StateMachine.characterUsedAbility = GameInfo.characterMoveTwo;
			playerSelectScript.ChooseTarget(StateMachine.characterUsedAbility);
		}
		if(GameInfo.characterMoveThree != null)
		{
			if (GUI.Button (new Rect (Screen.width - 150, Screen.height - 150, 100, 30), GameInfo.characterMoveThree.AbilityName))
			{
				StateMachine.characterUsedAbility = GameInfo.characterMoveThree;
				playerSelectScript.ChooseTarget(StateMachine.characterUsedAbility);
			}
		}
		if(GameInfo.characterMoveFour != null)
		{
			if (GUI.Button (new Rect (Screen.width - 250, Screen.height - 150, 100, 30), GameInfo.characterMoveFour.AbilityName))
			{
				StateMachine.characterUsedAbility = GameInfo.characterMoveFour;
				playerSelectScript.ChooseTarget(StateMachine.characterUsedAbility);
			}
		}
		if(GameInfo.characterMoveFive != null)
		{
			if (GUI.Button (new Rect (Screen.width - 350, Screen.height - 50, 100, 30), GameInfo.characterMoveFive.AbilityName))
			{
				StateMachine.characterUsedAbility = GameInfo.characterMoveFive;
				playerSelectScript.ChooseTarget(StateMachine.characterUsedAbility);
			}
		}*/
	}
	
}
