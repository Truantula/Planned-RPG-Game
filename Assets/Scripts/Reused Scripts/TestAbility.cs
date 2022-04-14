using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestAbility : MonoBehaviour {

	/*public static BaseAbility characterMoveOne;
	public static BaseAbility characterMoveTwo;
	public static BaseAbility characterMoveThree;
	public static BaseAbility characterMoveFour;
	public static BaseAbility characterMoveFive;
	public static BaseAbility characterMoveSix;
	public static BaseAbility characterMoveSeven;*/
	public GameObject Learn;
	
	public Text abilityOneText;
	public Text abilityTwoText;
	public Text abilityThreeText;
	public Text abilityFourText;
	public Text abilityFiveText;
	public Text abilitySixText;
	public Text abilitySevenText;
	public Text abilityEightText;
	public Text abilityNineText;
	public Text abilityTenText;
	
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			UpdateUI();
		}
	}
	
	public void LearnNewAbility()
	{
		if (GameInfo.unlearnedFormAbilities.Count == 0)
		{
			Debug.Log("Learn Tactic");
		}
		if (GameInfo.characterMoveTen == null && GameInfo.characterMoveNine != null && GameInfo.unlearnedFormAbilities.Count != 0)
		{
			int moveIndex = Random.Range(0, GameInfo.unlearnedFormAbilities.Count - 1);
			GameInfo.characterMoveTen = GameInfo.unlearnedFormAbilities[moveIndex];
			GameInfo.unlearnedFormAbilities.RemoveAt(moveIndex);
		}
		if (GameInfo.characterMoveNine == null && GameInfo.characterMoveEight != null && GameInfo.unlearnedFormAbilities.Count != 0)
		{
			int moveIndex = Random.Range(0, GameInfo.unlearnedFormAbilities.Count - 1);
			GameInfo.characterMoveNine = GameInfo.unlearnedFormAbilities[moveIndex];
			GameInfo.unlearnedFormAbilities.RemoveAt(moveIndex);
		}
		if (GameInfo.characterMoveEight == null && GameInfo.characterMoveSeven != null && GameInfo.unlearnedFormAbilities.Count != 0)
		{
			int moveIndex = Random.Range(0, GameInfo.unlearnedFormAbilities.Count - 1);
			GameInfo.characterMoveEight = GameInfo.unlearnedFormAbilities[moveIndex];
			GameInfo.unlearnedFormAbilities.RemoveAt(moveIndex);
		}
		if (GameInfo.characterMoveSeven == null && GameInfo.characterMoveSix != null && GameInfo.unlearnedFormAbilities.Count != 0)
		{
			int moveIndex = Random.Range(0, GameInfo.unlearnedFormAbilities.Count - 1);
			GameInfo.characterMoveSeven = GameInfo.unlearnedFormAbilities[moveIndex];
			GameInfo.unlearnedFormAbilities.RemoveAt(moveIndex);
		}
		if (GameInfo.characterMoveSix == null && GameInfo.characterMoveFive != null && GameInfo.unlearnedFormAbilities.Count != 0)
		{
			int moveIndex = Random.Range(0, GameInfo.unlearnedFormAbilities.Count - 1);
			GameInfo.characterMoveSix = GameInfo.unlearnedFormAbilities[moveIndex];
			GameInfo.unlearnedFormAbilities.RemoveAt(moveIndex);
		}
		if (GameInfo.characterMoveFive == null && GameInfo.characterMoveFour != null && GameInfo.unlearnedFormAbilities.Count != 0)
		{
			int moveIndex = Random.Range(0, GameInfo.unlearnedFormAbilities.Count - 1);
			GameInfo.characterMoveFive = GameInfo.unlearnedFormAbilities[moveIndex];
			GameInfo.unlearnedFormAbilities.RemoveAt(moveIndex);
		}
		if (GameInfo.characterMoveFour == null && GameInfo.characterMoveThree != null && GameInfo.unlearnedFormAbilities.Count != 0)
		{
			int moveIndex = Random.Range(0, GameInfo.unlearnedFormAbilities.Count - 1);
			GameInfo.characterMoveFour = GameInfo.unlearnedFormAbilities[moveIndex];
			GameInfo.unlearnedFormAbilities.RemoveAt(moveIndex);
		}
		if (GameInfo.characterMoveThree == null && GameInfo.unlearnedFormAbilities.Count != 0)
		{
			int moveIndex = Random.Range(0, GameInfo.unlearnedFormAbilities.Count - 1);
			GameInfo.characterMoveThree = GameInfo.unlearnedFormAbilities[moveIndex];
			GameInfo.unlearnedFormAbilities.RemoveAt(moveIndex);
		}
		UpdateUI();
	}
	
	public void UpdateUI()
	{
		abilityOneText.text = GameInfo.characterMoveOne.ToString();
		abilityTwoText.text = GameInfo.characterMoveTwo.ToString();
		if(GameInfo.characterMoveThree != null)
		{
			abilityThreeText.text = GameInfo.characterMoveThree.ToString();
		}
		else{
			abilityThreeText.text = "New Text";
		}
		if(GameInfo.characterMoveFour != null)
		{
			abilityFourText.text = GameInfo.characterMoveFour.ToString();
		}
		else{
			abilityFourText.text = "New Text";
		}
		if(GameInfo.characterMoveFive != null)
		{
			abilityFiveText.text = GameInfo.characterMoveFive.ToString();
		}
		else{
			abilityFiveText.text = "New Text";
		}
		if(GameInfo.characterMoveSix != null)
		{
			abilitySixText.text = GameInfo.characterMoveSix.ToString();
		}
		else{
			abilitySixText.text = "New Text";
		}
		if(GameInfo.characterMoveSeven != null)
		{
			abilitySevenText.text = GameInfo.characterMoveSeven.ToString();
		}
		else{
			abilitySevenText.text = "New Text";
		}
		if(GameInfo.characterMoveEight != null)
		{
			abilityEightText.text = GameInfo.characterMoveEight.ToString();
		}
		else{
			abilityEightText.text = "New Text";
		}
		if(GameInfo.characterMoveNine != null)
		{
			abilityNineText.text = GameInfo.characterMoveNine.ToString();
		}
		else{
			abilityNineText.text = "New Text";
		}
		if(GameInfo.characterMoveTen != null)
		{
			abilityTenText.text = GameInfo.characterMoveTen.ToString();
		}
		else{
			abilityTenText.text = "New Text";
		}
	}
}
