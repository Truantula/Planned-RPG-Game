using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAlly {
	
    private BaseAlly ally;
	
	public string allyName;
	
	public string allyFormName;
	
	public string allyDescription;

	private int combat;
	
	private int mind;
	
	private int resistance;
	
	private int luck;
	
	private int agility;
	
	private int initialhealth;
	
	private int initialwillpower;
	
	public BaseAlly Ally
	{
		get{ return ally;}
		set{ ally = value;}
	}
	
	public string AllyName {
		get{return allyName;}
		set{allyName = value;}
	}
	
	public string AllyFormName {
		get{return allyFormName;}
		set{allyFormName = value;}
	}
	
	public string AllyDescription {
		get{return allyDescription;}
		set{allyDescription = value;}
	}
	
	public List<BaseAbility> allyAbilities = new List<BaseAbility> ();
	
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
	public List<BaseAbility> AllyAbilities
	{
		get{return allyAbilities;}
		set{allyAbilities = value;}
	}
}