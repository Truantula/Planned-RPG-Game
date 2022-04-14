using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseForm {

	public string characterFormName;
	
	public string characterFormDescription;

	private int combat;
	
	private int mind;
	
	private int resistance;
	
	private int luck;
	
	private int agility;
	
	private int initialhealth;
	
	private int initialwillpower;
	
	public string CharacterFormName {
		get{return characterFormName;}
		set{characterFormName = value;}
	}
	
	public string CharacterFormDescription {
		get{return characterFormDescription;}
		set{characterFormDescription = value;}
	}
	
	public List<BaseAbility> characterAbilities = new List<BaseAbility> ();
	
	public int Combat
	{
		get{ return combat;}
		set{ combat = value; }
	}
	
	public int Mind
	{
		get{ return mind;}
		set{ mind = value; }
	}
	
	public int Resistance
	{
		get{ return resistance;}
		set{ resistance = value; }
	}
	
	public int Luck
	{
		get{ return luck;}
		set{ luck = value; }
	}
	
	public int Agility
	{
		get{ return agility;}
		set{ agility = value; }
	}
	
	public int InitialHealth
	{
		get{ return initialhealth;}
		set{ initialhealth = value; }
	}
	public int InitialWillpower
	{
		get{ return initialwillpower;}
		set{ initialwillpower = value; }
	}
	public List<BaseAbility> CharacterAbilities
	{
		get{return characterAbilities;}
		set{characterAbilities = value;}
	}
}