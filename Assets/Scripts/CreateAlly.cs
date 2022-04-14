using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAlly : MonoBehaviour
{
	private MyAlly newAlly;

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
		newAlly = new MyAlly();
	}
	
	public void CreateNewAlly()
	{
		AllyInfo.info.AllyName = newAlly.AllyName;
		AllyInfo.info.AllyFormName = newAlly.AllyFormName;
		AllyInfo.info.AllyDescription = newAlly.AllyDescription;
		
		AllyInfo.Ally = newAlly.Ally;
		AllyInfo.info.Combat = newAlly.Combat;
		AllyInfo.info.Mind = newAlly.Mind;
		AllyInfo.info.Resistance = newAlly.Resistance;
		AllyInfo.info.Luck = newAlly.Luck;
		AllyInfo.info.Agility = newAlly.Agility;
		AllyInfo.info.InitialHealth = newAlly.InitialHealth;
		AllyInfo.info.InitialWillpower = newAlly.InitialWillpower;
		SaveInfo.SaveAllInfo();
	}
	
	// Update is called once per frame
	public void SetDreamerAlly() 
	{
		newAlly.Ally = new DreamerAlly();
		AllyInfo.info.AllyName = newAlly.AllyName;
		AllyInfo.info.AllyFormName = newAlly.Ally.AllyFormName;
		AllyInfo.info.AllyDescription = newAlly.Ally.AllyDescription;
		newAlly.Combat = newAlly.Ally.Combat;
		AllyInfo.info.Combat = newAlly.Combat;// += AddCombat;
		newAlly.Mind = newAlly.Ally.Mind; 
		AllyInfo.info.Mind = newAlly.Mind;// += AddMind;
		newAlly.Resistance = newAlly.Ally.Resistance;
		AllyInfo.info.Resistance = newAlly.Resistance;// += AddResistance;		
		newAlly.Luck = newAlly.Ally.Luck; 
		AllyInfo.info.Luck = newAlly.Luck;// += AddLuck;
		newAlly.Agility = newAlly.Ally.Agility; 
		AllyInfo.info.Agility = newAlly.Agility;// += AddAgility;
		health.MaxVal = newAlly.Ally.InitialHealth;
		AllyInfo.info.InitialHealth = health.MaxVal;// += AddInitialHealth;
		willpower.MaxVal = newAlly.Ally.InitialWillpower;
		AllyInfo.info.InitialWillpower = willpower.MaxVal;
		/*AllyInfo.characterImmunities.Clear();
		AllyInfo.unlearnedFormAbilities.Clear();
		AllyInfo.characterMoveOne = null;
		AllyInfo.characterMoveTwo = null;
		AllyInfo.characterMoveThree = null;
		AllyInfo.characterMoveFour = null;
		AllyInfo.characterMoveFive = null;
		AllyInfo.characterMoveSix = null;
		AllyInfo.characterMoveSeven = null;
		AllyInfo.characterMoveEight = null;
		AllyInfo.characterMoveNine = null;
		AllyInfo.characterMoveTen = null;
		AllyInfo.characterMoveOne = newAlly.Ally.characterAbilities[0];
		AllyInfo.characterMoveTwo = newAlly.Ally.characterAbilities[1]; */
		//AllyInfo.unlearnedFormAbilities.Add(new PossibleMove());
		AllyInfo.info.UpdateUI();
		Initialize();
	}
	
	//void UpdateUI()
	//{
	//	combatText.text = AllyInfo.info.Combat.ToString();
	//	mindText.text = newAlly.Mind.ToString();
	//	resistanceText.text = newAlly.Resistance.ToString();
	//	luckText.text = newAlly.Luck.ToString();
	//	agilityText.text = newAlly.Agility.ToString();
	//	nameText.text = newAlly.CharacterFormName.ToString();
	//	descriptionText.text = newAlly.CharacterFormDescription.ToString();
	//}
	
	public void Initialize()
	{
		health.MaxVal = health.maxVal;
		health.CurrentVal = health.currentVal;
		willpower.MaxVal = willpower.maxVal;
		willpower.CurrentVal = willpower.currentVal;
	}
	
	/*public void SetCombat(int amount)
	{
		if(newAlly.Ally != null)
		{
			AddCombat += amount;
			//newAlly.Combat += amount;
			AllyInfo.info.Combat = newAlly.Combat += AddCombat;
			AllyInfo.info.UpdateUI();
		}
		else
		{
			Debug.Log("No Character Chosen!");
		}
	}
	
	public void SetMind(int amount)
	{
		if(newAlly.Ally != null)
		{
			AddMind += amount;
			//newAlly.Mind += amount;
			AllyInfo.info.Mind = newAlly.Mind += AddMind;
			AllyInfo.info.UpdateUI();
		}
		else
		{
			Debug.Log("No Character Chosen!");
		}
	}
	public void SetResistance(int amount)
	{
		if(newAlly.Ally != null)
		{
			AddResistance += amount;
			//newAlly.Resistance += amount;
			AllyInfo.info.Resistance = newAlly.Resistance += AddResistance;
			AllyInfo.info.UpdateUI();
		}
		else
		{
			Debug.Log("No Character Chosen!");
		}
	}
	public void SetLuck(int amount)
	{
		if(newAlly.Ally != null)
		{
			AddLuck += amount;
			//newAlly.Luck += amount;
			AllyInfo.info.Luck = newAlly.Luck += AddLuck;
			AllyInfo.info.UpdateUI();
		}
		else
		{
			Debug.Log("No Character Chosen!");
		}
	}
	public void SetAgility(int amount)
	{
		if(newAlly.Ally != null)
		{
			AddAgility += amount;
			//newAlly.Agility += amount;
			AllyInfo.info.Agility = newAlly.Agility += AddAgility;
			AllyInfo.info.UpdateUI();		
		}
		else
		{
			Debug.Log("No Character Chosen!");
		}
	}*/
	public void SetInitialHealth(int amount)
	{
		if(newAlly.Ally != null)
		{	
			//AddInitialHealth += amount;
			health.MaxVal += amount;
			//newAlly.InitialHealth += amount;
			//AllyInfo.info.InitialHealth = health.MaxVal += AddInitialHealth;
			AllyInfo.info.UpdateUI();	
		}
		else
		{
			Debug.Log("No Character Chosen!");
		}
	}
	public void SetInitialWillpower(int amount)
	{
		if(newAlly.Ally != null)
		{	
			//AddInitialWillpower += amount;
			willpower.MaxVal += amount;
			//newAlly.InitialWillpower += amount;
			//AllyInfo.info.InitialWillpower = willpower.MaxVal += AddInitialWillpower;
			AllyInfo.info.UpdateUI();
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
	
	/*public void LearnNewAbility()
	{
		if (AllyInfo.unlearnedFormAbilities.Count == 0)
		{
			Debug.Log("Learn Tactic");
		}
		if (AllyInfo.characterMoveTen == null && AllyInfo.characterMoveNine != null && AllyInfo.unlearnedFormAbilities.Count != 0)
		{
			int moveIndex = Random.Range(0, AllyInfo.unlearnedFormAbilities.Count - 1);
			AllyInfo.characterMoveTen = AllyInfo.unlearnedFormAbilities[moveIndex];
			AllyInfo.unlearnedFormAbilities.RemoveAt(moveIndex);
		}
		if (AllyInfo.characterMoveNine == null && AllyInfo.characterMoveEight != null && AllyInfo.unlearnedFormAbilities.Count != 0)
		{
			int moveIndex = Random.Range(0, AllyInfo.unlearnedFormAbilities.Count - 1);
			AllyInfo.characterMoveNine = AllyInfo.unlearnedFormAbilities[moveIndex];
			AllyInfo.unlearnedFormAbilities.RemoveAt(moveIndex);
		}
		if (AllyInfo.characterMoveEight == null && AllyInfo.characterMoveSeven != null && AllyInfo.unlearnedFormAbilities.Count != 0)
		{
			int moveIndex = Random.Range(0, AllyInfo.unlearnedFormAbilities.Count - 1);
			AllyInfo.characterMoveEight = AllyInfo.unlearnedFormAbilities[moveIndex];
			AllyInfo.unlearnedFormAbilities.RemoveAt(moveIndex);
		}
		if (AllyInfo.characterMoveSeven == null && AllyInfo.characterMoveSix != null && AllyInfo.unlearnedFormAbilities.Count != 0)
		{
			int moveIndex = Random.Range(0, AllyInfo.unlearnedFormAbilities.Count - 1);
			AllyInfo.characterMoveSeven = AllyInfo.unlearnedFormAbilities[moveIndex];
			AllyInfo.unlearnedFormAbilities.RemoveAt(moveIndex);
		}
		if (AllyInfo.characterMoveSix == null && AllyInfo.characterMoveFive != null && AllyInfo.unlearnedFormAbilities.Count != 0)
		{
			int moveIndex = Random.Range(0, AllyInfo.unlearnedFormAbilities.Count - 1);
			AllyInfo.characterMoveSix = AllyInfo.unlearnedFormAbilities[moveIndex];
			AllyInfo.unlearnedFormAbilities.RemoveAt(moveIndex);
		}
		if (AllyInfo.characterMoveFive == null && AllyInfo.characterMoveFour != null && AllyInfo.unlearnedFormAbilities.Count != 0)
		{
			int moveIndex = Random.Range(0, AllyInfo.unlearnedFormAbilities.Count - 1);
			AllyInfo.characterMoveFive = AllyInfo.unlearnedFormAbilities[moveIndex];
			AllyInfo.unlearnedFormAbilities.RemoveAt(moveIndex);
		}
		if (AllyInfo.characterMoveFour == null && AllyInfo.characterMoveThree != null && AllyInfo.unlearnedFormAbilities.Count != 0)
		{
			int moveIndex = Random.Range(0, AllyInfo.unlearnedFormAbilities.Count - 1);
			AllyInfo.characterMoveFour = AllyInfo.unlearnedFormAbilities[moveIndex];
			AllyInfo.unlearnedFormAbilities.RemoveAt(moveIndex);
		}
		if (AllyInfo.characterMoveThree == null && AllyInfo.unlearnedFormAbilities.Count != 0)
		{
			int moveIndex = Random.Range(0, AllyInfo.unlearnedFormAbilities.Count - 1);
			AllyInfo.characterMoveThree = AllyInfo.unlearnedFormAbilities[moveIndex];
			AllyInfo.unlearnedFormAbilities.RemoveAt(moveIndex);
		}
	}*/
}
