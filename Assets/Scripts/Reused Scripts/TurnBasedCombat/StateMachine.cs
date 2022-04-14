using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateMachine : MonoBehaviour {

	public static BaseAbility characterUsedAbility;
	private BattleCalculations battleCalcScript = new BattleCalculations ();
	private PlayerSelect playerSelectScript = new PlayerSelect ();
	private BattleStateEnemyChoice battleStateEnemyChoiceScript = new BattleStateEnemyChoice ();
	public static int totalTurnCount;
	public static bool characterCompleteTurn;
	public static bool enemyCompleteTurn;
	public static bool moved;
	private GameObject offComponent;
	public static bool singleTarget;
	public GameObject selfTarget;
	public GameObject characterPanel;
	
	public enum BattleStates
	{
		START,
		PLAYERCHOICE,
		PLAYERSELECT,
		ENEMYCHOICE,
		LOSE,
		WIN,
		ADDSTATUSEFFECTS,
		CALCDAMAGE,
		ENDTURN
	}
	
	public static BattleStates currentState;
	

	// Use this for initialization
	void Start () 
	{
		totalTurnCount = 1;
		currentState = BattleStates.START;
		GameObject[] enemyList = GameObject.FindGameObjectsWithTag("enemy");
		foreach (GameObject creature in enemyList)
		{
			creature.GetComponent<BaseEnemy>().InitializeImmunities();
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		switch(currentState)
		{
			//randomEnemyAppear
			case (BattleStates.START):
			BattleStateStart.PrepareBattle();
				break;
			case (BattleStates.PLAYERCHOICE):
				break;
			case (BattleStates.PLAYERSELECT):
			playerSelectScript.ChooseTarget(characterUsedAbility);
				break;
			case (BattleStates.ENEMYCHOICE):
			battleStateEnemyChoiceScript.EnemyAction();
			TurnCheck();
				break;
			case (BattleStates.LOSE):
				break;
			case (BattleStates.WIN):
				break;
			case (BattleStates.CALCDAMAGE):
			StartCoroutine(ConfirmTarget());
			//TurnCheck();
				break;
			case (BattleStates.ENDTURN):
			totalTurnCount += 1;
			//initialize applied status effects
			characterCompleteTurn = false;
			enemyCompleteTurn = false;
				break;
		}
	}
	
	void OnGUI()
	{
		if(GUILayout.Button("NEXT STATE"))
		{
			if(currentState == BattleStates.START)
			{
				currentState = BattleStates.PLAYERCHOICE;
			}
			else if(currentState  == BattleStates.PLAYERCHOICE)
			{
				currentState = BattleStates.ENEMYCHOICE;
			}
			else if(currentState  == BattleStates.ENEMYCHOICE)
			{
				currentState = BattleStates.LOSE;
			}
			else if(currentState  == BattleStates.LOSE)
			{
				currentState = BattleStates.WIN;
			}
			else if(currentState  == BattleStates.WIN)
			{
				currentState = BattleStates.START;
			}
		}
	}
	
	private void TurnCheck()
	{
		if (characterCompleteTurn && !enemyCompleteTurn)
		{
			currentState = BattleStates.ENEMYCHOICE;
		}
		if (!characterCompleteTurn && enemyCompleteTurn)
		{
			currentState = BattleStates.PLAYERCHOICE;
		}
		if (characterCompleteTurn && enemyCompleteTurn)
		{
			currentState = BattleStates.ENDTURN;
		}
	}
	
	private IEnumerator ConfirmTarget() 
	{
	if (singleTarget == true)
	{
			playerSelectScript.Update();
	}

    yield return waitForKeyPress(KeyCode.Space); // wait for this function to return
	if (moved) 
	{
		GameObject BattleManager = GameObject.Find("BattleManager");
		BattleGUI battleGUI = BattleManager.GetComponent<BattleGUI>();
		foreach (GameObject target in battleGUI.targets)
			{
				switch (target.tag)
				{
					case "Player":
					selfTarget = GameObject.FindGameObjectWithTag("Player");
					characterPanel = selfTarget.transform.Find("CharacterPanel").gameObject;
					offComponent = characterPanel.transform.Find("SelectArrow").gameObject;
					offComponent.GetComponent<Image>().enabled = false;
					offComponent.GetComponent<Animator>().enabled = false;
					break;
					case "enemy":
					offComponent = target.transform.Find("SelectArrow").gameObject;
					offComponent.GetComponent<Image>().enabled = false;
					offComponent.GetComponent<Animator>().enabled = false;
					break;
				}
			}
		GameObject createPlayer = GameObject.Find("CreatePlayer");
		CreateCharacter createCharacter = createPlayer.GetComponent<CreateCharacter>();
		createCharacter.willpower.CurrentVal -= characterUsedAbility.WPCost;
		battleCalcScript.CalculateTotalDamage(characterUsedAbility);
	}
	else
	{
		TurnCheck();
	}
    // do other stuff after key press
	}
 
	private IEnumerator waitForKeyPress(KeyCode key)
	{
    bool done = false;
    while(!done) // essentially a "while true", but with a bool to break out naturally
    {
        if(Input.GetKeyDown(key))
        {
            done = true; // breaks the loop
        }
        yield return null; // wait until next frame, then continue execution from here (loop continues)
    }
	}
	
}






