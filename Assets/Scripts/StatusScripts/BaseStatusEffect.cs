using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStatusEffect {
	
	private string statusEffectName;
	private string statusEffectDescription;
	private int statusEffectID;
	private bool ifTurnDuration;
	private bool ifPercentage;
	private int basePercentFluct;
	private string variantMinorName;
	private float minorBound;
	private string variantMajorName;
	private float majorBound;
	private string variantExtremeName;
	private float extremeBound;
	private bool ifEffectOnHundred;
	private bool ifEffectOnZero;
	private bool remainAfterBattle;
	private bool removeWhenInjured;
	
	public string StatusEffectName
	{
		get{return statusEffectName;}
		set{statusEffectName = value;}
	}
	public string StatusEffectDescription
	{
		get{return statusEffectDescription;}
		set{statusEffectDescription = value;}
	}
	public int StatusEffectID
	{
		get{return statusEffectID;}
		set{statusEffectID = value;}
	}
	public bool IfTurnDuration
	{
		get{return ifTurnDuration;}
		set{ifTurnDuration = value;}
	}
	public bool IfPercentage
	{
		get{return ifPercentage;}
		set{ifPercentage = value;}
	}
	public int BasePercentFluct
	{
		get{return basePercentFluct;}
		set{basePercentFluct = value;}
	}
	public string VariantMinorName
	{
		get{return variantMinorName;}
		set{variantMinorName = value;}
	}	
	public float MinorBound
	{
		get{return minorBound;}
		set{minorBound = value;}
	}	
	public string VariantMajorName
	{
		get{return variantMajorName;}
		set{variantMajorName = value;}
	}	
	public float MajorBound
	{
		get{return majorBound;}
		set{majorBound = value;}
	}
	public string VariantExtremeName
	{
		get{return variantExtremeName;}
		set{variantExtremeName = value;}
	}	
	public float ExtremeBound
	{
		get{return extremeBound;}
		set{extremeBound = value;}
	}
	public bool IfEffectOnHundred
	{
		get{return ifEffectOnHundred;}
		set{ifEffectOnHundred = value;}
	}
	public bool IfEffectOnZero
	{
		get{return ifEffectOnZero;}
		set{ifEffectOnZero = value;}
	}	
	public bool RemainAfterBattle
	{
		get{return remainAfterBattle;}
		set{remainAfterBattle = value;}
	}
	public bool RemoveWhenInjured
	{
		get{return removeWhenInjured;}
		set{removeWhenInjured = value;}
	}
}
