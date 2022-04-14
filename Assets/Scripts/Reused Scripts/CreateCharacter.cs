using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateCharacter : MonoBehaviour {

	private BaseCharacterForm newCharacter;

	public static int AddCombat;
	public static int AddMind;
	public static int AddResistance;
	public static int AddLuck;
	public static int AddAgility;
	public static int AddExperience;
	public static int AddLevel;
	public static int AddInitialHealth;
	public static int AddInitialWillpower;
	
	[SerializeField]
	public Stat health;
	
	[SerializeField]
	public Stat willpower;
	
	private void Awake()
	{
		health.Initialize();
		willpower.Initialize();
	}
	
	// Use this for initialization
	void Start () 
	{
		newCharacter = new BaseCharacterForm();
	}
	
	public void CreateNewCharacter()
	{
		GameInfo.info.CharacterFormName = newCharacter.CharacterFormName;
		GameInfo.info.CharacterFormDescription = newCharacter.CharacterFormDescription;
		
		GameInfo.CharacterForm = newCharacter.CharacterForm;
		GameInfo.info.Combat = newCharacter.Combat;
		GameInfo.info.Mind = newCharacter.Mind;
		GameInfo.info.Resistance = newCharacter.Resistance;
		GameInfo.info.Luck = newCharacter.Luck;
		GameInfo.info.Agility = newCharacter.Agility;
		GameInfo.info.InitialHealth = newCharacter.InitialHealth;
		GameInfo.info.InitialWillpower = newCharacter.InitialWillpower;
		SaveInfo.SaveAllInfo();
	}
	
	// Update is called once per frame
	public void SetHumanForm() 
	{
		newCharacter.CharacterForm = new BaseHumanForm();
		GameInfo.info.CharacterFormName = newCharacter.CharacterForm.CharacterFormName;
		GameInfo.info.CharacterFormDescription = newCharacter.CharacterForm.CharacterFormDescription;
		newCharacter.Combat = newCharacter.CharacterForm.Combat;
		GameInfo.info.Combat = newCharacter.Combat += AddCombat;
		newCharacter.Mind = newCharacter.CharacterForm.Mind; 
		GameInfo.info.Mind = newCharacter.Mind += AddMind;
		newCharacter.Resistance = newCharacter.CharacterForm.Resistance;
		GameInfo.info.Resistance = newCharacter.Resistance += AddResistance;		
		newCharacter.Luck = newCharacter.CharacterForm.Luck; 
		GameInfo.info.Luck = newCharacter.Luck += AddLuck;
		newCharacter.Agility = newCharacter.CharacterForm.Agility; 
		GameInfo.info.Agility = newCharacter.Agility += AddAgility;
		health.MaxVal = newCharacter.CharacterForm.InitialHealth;
		GameInfo.info.InitialHealth = health.MaxVal += AddInitialHealth;
		willpower.MaxVal = newCharacter.CharacterForm.InitialWillpower += AddInitialWillpower;
		/*GameInfo.characterImmunities.Clear();
		GameInfo.unlearnedFormAbilities.Clear();
		GameInfo.characterMoveOne = null;
		GameInfo.characterMoveTwo = null;
		GameInfo.characterMoveThree = null;
		GameInfo.characterMoveFour = null;
		GameInfo.characterMoveFive = null;
		GameInfo.characterMoveSix = null;
		GameInfo.characterMoveSeven = null;
		GameInfo.characterMoveEight = null;
		GameInfo.characterMoveNine = null;
		GameInfo.characterMoveTen = null;
		GameInfo.characterMoveOne = newCharacter.CharacterForm.characterAbilities[0];
		GameInfo.characterMoveTwo = newCharacter.CharacterForm.characterAbilities[1]; */
		//GameInfo.unlearnedFormAbilities.Add(new PossibleMove());
		GameInfo.info.UpdateUI();
		Initialize();
	}
	
	public void SetUndeadForm() 
	{
		newCharacter.CharacterForm = new BaseUndeadForm();
		GameInfo.info.CharacterFormName = newCharacter.CharacterForm.CharacterFormName;
		GameInfo.info.CharacterFormDescription = newCharacter.CharacterForm.CharacterFormDescription;
		newCharacter.Combat = newCharacter.CharacterForm.Combat;
		GameInfo.info.Combat = newCharacter.Combat += AddCombat;
		newCharacter.Mind = newCharacter.CharacterForm.Mind; 
		GameInfo.info.Mind = newCharacter.Mind += AddMind;
		newCharacter.Resistance = newCharacter.CharacterForm.Resistance;
		GameInfo.info.Resistance = newCharacter.Resistance += AddResistance;		
		newCharacter.Luck = newCharacter.CharacterForm.Luck; 
		GameInfo.info.Luck = newCharacter.Luck += AddLuck;
		newCharacter.Agility = newCharacter.CharacterForm.Agility; 
		GameInfo.info.Agility = newCharacter.Agility += AddAgility;
		health.MaxVal = newCharacter.CharacterForm.InitialHealth;
		GameInfo.info.InitialHealth = health.MaxVal += AddInitialHealth;
		willpower.MaxVal = newCharacter.CharacterForm.InitialWillpower += AddInitialWillpower;
		GameInfo.characterImmunities.Clear();
		GameInfo.unlearnedFormAbilities.Clear();
		GameInfo.characterMoveOne = null;
		GameInfo.characterMoveTwo = null;
		GameInfo.characterMoveThree = null;
		GameInfo.characterMoveFour = null;
		GameInfo.characterMoveFive = null;
		GameInfo.characterMoveSix = null;
		GameInfo.characterMoveSeven = null;
		GameInfo.characterMoveEight = null;
		GameInfo.characterMoveNine = null;
		GameInfo.characterMoveTen = null;
		GameInfo.characterMoveOne = newCharacter.CharacterForm.characterAbilities[0];
		GameInfo.characterMoveTwo = newCharacter.CharacterForm.characterAbilities[1];
		GameInfo.info.UpdateUI();
		Initialize();
		//GameInfo.characterImmunities.Add(new BleedStatus());
		//GameInfo.characterImmunities.Add(new PowerfulStatus());
		//GameInfo.characterImmunities.Add(new ResistantStatus());
	}
	
	public void SetWeldForm() 
	{
		newCharacter.CharacterForm = new BaseWeldForm();
		GameInfo.info.CharacterFormName = newCharacter.CharacterForm.CharacterFormName;
		GameInfo.info.CharacterFormDescription = newCharacter.CharacterForm.CharacterFormDescription;
		newCharacter.Combat = newCharacter.CharacterForm.Combat;
		GameInfo.info.Combat = newCharacter.Combat += AddCombat;
		newCharacter.Mind = newCharacter.CharacterForm.Mind; 
		GameInfo.info.Mind = newCharacter.Mind += AddMind;
		newCharacter.Resistance = newCharacter.CharacterForm.Resistance;
		GameInfo.info.Resistance = newCharacter.Resistance += AddResistance;		
		newCharacter.Luck = newCharacter.CharacterForm.Luck; 
		GameInfo.info.Luck = newCharacter.Luck += AddLuck;
		newCharacter.Agility = newCharacter.CharacterForm.Agility; 
		GameInfo.info.Agility = newCharacter.Agility += AddAgility;
		health.MaxVal = newCharacter.CharacterForm.InitialHealth;
		GameInfo.info.InitialHealth = health.MaxVal += AddInitialHealth;
		willpower.MaxVal = newCharacter.CharacterForm.InitialWillpower += AddInitialWillpower;
		GameInfo.characterImmunities.Clear();
		GameInfo.unlearnedFormAbilities.Clear();
		GameInfo.characterMoveOne = null;
		GameInfo.characterMoveTwo = null;
		GameInfo.characterMoveThree = null;
		GameInfo.characterMoveFour = null;
		GameInfo.characterMoveFive = null;
		GameInfo.characterMoveSix = null;
		GameInfo.characterMoveSeven = null;
		GameInfo.characterMoveEight = null;
		GameInfo.characterMoveNine = null;
		GameInfo.characterMoveTen = null;
		GameInfo.characterMoveOne = newCharacter.CharacterForm.characterAbilities[0];
		GameInfo.characterMoveTwo = newCharacter.CharacterForm.characterAbilities[1];
		//GameInfo.unlearnedFormAbilities.Add(new PossibleMove());
		GameInfo.info.UpdateUI();
		Initialize();
	}
	
	public void SetReptileForm() 
	{
		newCharacter.CharacterForm = new BaseReptileForm();
		GameInfo.info.CharacterFormName = newCharacter.CharacterForm.CharacterFormName;
		GameInfo.info.CharacterFormDescription = newCharacter.CharacterForm.CharacterFormDescription;
		newCharacter.Combat = newCharacter.CharacterForm.Combat;
		GameInfo.info.Combat = newCharacter.Combat += AddCombat;
		newCharacter.Mind = newCharacter.CharacterForm.Mind; 
		GameInfo.info.Mind = newCharacter.Mind += AddMind;
		newCharacter.Resistance = newCharacter.CharacterForm.Resistance;
		GameInfo.info.Resistance = newCharacter.Resistance += AddResistance;		
		newCharacter.Luck = newCharacter.CharacterForm.Luck; 
		GameInfo.info.Luck = newCharacter.Luck += AddLuck;
		newCharacter.Agility = newCharacter.CharacterForm.Agility; 
		GameInfo.info.Agility = newCharacter.Agility += AddAgility;
		health.MaxVal = newCharacter.CharacterForm.InitialHealth;
		GameInfo.info.InitialHealth = health.MaxVal += AddInitialHealth;
		willpower.MaxVal = newCharacter.CharacterForm.InitialWillpower += AddInitialWillpower;
		GameInfo.characterImmunities.Clear();
		GameInfo.unlearnedFormAbilities.Clear();
		GameInfo.characterMoveOne = null;
		GameInfo.characterMoveTwo = null;
		GameInfo.characterMoveThree = null;
		GameInfo.characterMoveFour = null;
		GameInfo.characterMoveFive = null;
		GameInfo.characterMoveSix = null;
		GameInfo.characterMoveSeven = null;
		GameInfo.characterMoveEight = null;
		GameInfo.characterMoveNine = null;
		GameInfo.characterMoveTen = null;
		GameInfo.characterMoveOne = newCharacter.CharacterForm.characterAbilities[0];
		GameInfo.characterMoveTwo = newCharacter.CharacterForm.characterAbilities[1];
		//GameInfo.unlearnedFormAbilities.Add(new PossibleMove());
		GameInfo.info.UpdateUI();
		Initialize();
		//GameInfo.unlearnedFormAbilities.Add(new Petrify());
		//GameInfo.unlearnedFormAbilities.Add(new SlimyMaw());
		//GameInfo.unlearnedFormAbilities.Add(new Fly());
		//GameInfo.unlearnedFormAbilities.Add(new Regenerate());
		//GameInfo.unlearnedFormAbilities.Add(new DragonClaw());
	}
	
	//void UpdateUI()
	//{
	//	combatText.text = GameInfo.info.Combat.ToString();
	//	mindText.text = newCharacter.Mind.ToString();
	//	resistanceText.text = newCharacter.Resistance.ToString();
	//	luckText.text = newCharacter.Luck.ToString();
	//	agilityText.text = newCharacter.Agility.ToString();
	//	nameText.text = newCharacter.CharacterFormName.ToString();
	//	descriptionText.text = newCharacter.CharacterFormDescription.ToString();
	//}
	
	public void Initialize()
	{
		health.MaxVal = health.maxVal;
		health.CurrentVal = health.currentVal;
		willpower.MaxVal = willpower.maxVal;
		willpower.CurrentVal = willpower.currentVal;
	}
	
	public void SetCombat(int amount)
	{
		if(newCharacter.CharacterForm != null)
		{
			AddCombat += amount;
			//newCharacter.Combat += amount;
			GameInfo.info.Combat = newCharacter.Combat += AddCombat;
			GameInfo.info.UpdateUI();
		}
		else
		{
			Debug.Log("No Character Chosen!");
		}
	}
	
	public void SetMind(int amount)
	{
		if(newCharacter.CharacterForm != null)
		{
			AddMind += amount;
			//newCharacter.Mind += amount;
			GameInfo.info.Mind = newCharacter.Mind += AddMind;
			GameInfo.info.UpdateUI();
		}
		else
		{
			Debug.Log("No Character Chosen!");
		}
	}
	public void SetResistance(int amount)
	{
		if(newCharacter.CharacterForm != null)
		{
			AddResistance += amount;
			//newCharacter.Resistance += amount;
			GameInfo.info.Resistance = newCharacter.Resistance += AddResistance;
			GameInfo.info.UpdateUI();
		}
		else
		{
			Debug.Log("No Character Chosen!");
		}
	}
	public void SetLuck(int amount)
	{
		if(newCharacter.CharacterForm != null)
		{
			AddLuck += amount;
			//newCharacter.Luck += amount;
			GameInfo.info.Luck = newCharacter.Luck += AddLuck;
			GameInfo.info.UpdateUI();
		}
		else
		{
			Debug.Log("No Character Chosen!");
		}
	}
	public void SetAgility(int amount)
	{
		if(newCharacter.CharacterForm != null)
		{
			AddAgility += amount;
			//newCharacter.Agility += amount;
			GameInfo.info.Agility = newCharacter.Agility += AddAgility;
			GameInfo.info.UpdateUI();		
		}
		else
		{
			Debug.Log("No Character Chosen!");
		}
	}
	public void SetInitialHealth(int amount)
	{
		if(newCharacter.CharacterForm != null)
		{	
			AddInitialHealth += amount;
			health.MaxVal += amount;
			//newCharacter.InitialHealth += amount;
			GameInfo.info.InitialHealth = health.MaxVal += AddInitialHealth;
			GameInfo.info.UpdateUI();	
		}
		else
		{
			Debug.Log("No Character Chosen!");
		}
	}
	public void SetInitialWillpower(int amount)
	{
		if(newCharacter.CharacterForm != null)
		{	
			AddInitialWillpower += amount;
			willpower.MaxVal += amount;
			//newCharacter.InitialWillpower += amount;
			GameInfo.info.InitialWillpower = willpower.MaxVal += AddInitialWillpower;
			GameInfo.info.UpdateUI();
		}
		else
		{
			Debug.Log("No Character Chosen!");
		}
	}
	public void TakeDamage(int amount)
	{
		health.CurrentVal -= amount;
	}
	public void TakeWPDamage(int amount)
	{
		willpower.CurrentVal -= amount;
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
	}
}
