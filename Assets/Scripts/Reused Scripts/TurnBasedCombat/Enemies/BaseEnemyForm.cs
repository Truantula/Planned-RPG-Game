using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemyForm {

	private BaseEnemy enemyForm;
	
	public string enemyFormName;
	
	public string enemyFormDescription;

	private int combat;
	
	private int mind;
	
	private int resistance;
	
	private int luck;
	
	private int agility;
	
	private int initialhealth;
	
	private int initialwillpower;
	
	private List<BaseStatusEffect> enemyImmunities = new List<BaseStatusEffect> ();
	
	public string EnemyFormName {
		get{return enemyFormName;}
		set{enemyFormName = value;}
	}
	public string EnemyFormDescription {
		get{return enemyFormDescription;}
		set{enemyFormDescription = value;}
	}
	
	public BaseEnemy EnemyForm
	{
		get{ return enemyForm;}
		set{ enemyForm = value;}
	}
	
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
	public List<BaseStatusEffect> EnemyImmunities
	{
		get{return enemyImmunities;}
		set{enemyImmunities = value;}
	}
}
