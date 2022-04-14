using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseAbility {

	private string abilityName;
	private string abilityDescription;
	private int abilityID;
	private int abilityPower;
	private int wpCost;
	private List<BaseStatusEffect> abilityStatusEffects = new List<BaseStatusEffect> ();
	private List<BaseStatusEffect> removeEffects = new List<BaseStatusEffect> ();
	private int abilityCritChance;
	private string abilityTarget;
	private int abilityAccuracy;
	private float statusApplyChance;
	private int wpDamagePower;
	//private float wpRestore;
	//private float recoilDamage;
	//private List<BaseStatusEffect> recoilState = new List<BaseStatusEffect> ();
	
	public string AbilityName
	{
		get{return abilityName;}
		set{abilityName = value;}
	}
	public string AbilityDescription
	{
		get{return abilityDescription;}
		set{abilityDescription = value;}
	}
	public int AbilityID
	{
		get{return abilityID;}
		set{abilityID = value;}
	}
	public int AbilityPower
	{
		get{return abilityPower;}
		set{abilityPower = value;}
	}
	public int WPCost
	{
		get{return wpCost;}
		set{wpCost = value;}
	}
	public List<BaseStatusEffect> AbilityStatusEffects
	{
		get{return abilityStatusEffects;}
		set{abilityStatusEffects = value;}
	}
	public List<BaseStatusEffect> RemoveEffects
	{
		get{return removeEffects;}
		set{removeEffects = value;}
	}
	public int AbilityCritChance
	{
		get{return abilityCritChance;}
		set{abilityCritChance = value;}
	}
	public string AbilityTarget
	{
		get{return abilityTarget;}
		set{abilityTarget = value;}
	}
	public int AbilityAccuracy
	{
		get{return abilityAccuracy;}
		set{abilityAccuracy = value;}
	}
	public float StatusApplyChance
	{
		get{return statusApplyChance;}
		set{statusApplyChance = value;}
	}
	public int WPDamagePower
	{
		get{return wpDamagePower;}
		set{wpDamagePower = value;}
	}
}
