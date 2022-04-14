using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour{
	
	public string enemyFormName;
	
	public string enemyFormDescription;

	public int combat;
	
	public int mind;
	
	public int resistance;
	
	public int luck;
	
	public int agility;
	
	public int initialhealth;
	
	public int initialwillpower;
	
	public GameObject findStatus;
	
	public bool bleedImmune;
	
	public bool blindImmune;
	
	public bool frailImmune;
	
	public bool impotentImmune;
	
	public bool poisonImmune;
	
	public bool reekingImmune;
	
	public bool vulnerableImmune;
	
	public bool weakImmune;
	
	public bool recoveringImmune;
	
	public List<BaseAbility> enemyMoves = new List<BaseAbility>();
	
	public string EnemyFormName {
		get{return enemyFormName;}
		set{enemyFormName = value;}
	}
	public string EnemyFormDescription {
		get{return enemyFormDescription;}
		set{enemyFormDescription = value;}
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
	
	public void InitializeImmunities()
	{
		findStatus = gameObject.transform.Find("statusIcons").gameObject;
		StatusManager statusManager = findStatus.GetComponent<StatusManager>();
		if (bleedImmune)
		{
			statusManager.internalManager.characterImmunities.Add("Bleed");
		}
		if (blindImmune)
		{
			statusManager.internalManager.characterImmunities.Add("Blinded");
		}
		if (frailImmune)
		{
			statusManager.internalManager.characterImmunities.Add("Frail");
		}
		if (impotentImmune)
		{
			statusManager.internalManager.characterImmunities.Add("Impotent");
		}
		if (poisonImmune)
		{
			statusManager.internalManager.characterImmunities.Add("Poisoned");
		}
		if (reekingImmune)
		{
			statusManager.internalManager.characterImmunities.Add("Reeking");
		}
		if (vulnerableImmune)
		{
			statusManager.internalManager.characterImmunities.Add("Vulnerable");
		}
		if (weakImmune)
		{
			statusManager.internalManager.characterImmunities.Add("Weakness");
		}
		if (recoveringImmune)
		{
			statusManager.internalManager.characterImmunities.Add("Stun");
		}
	}
}
