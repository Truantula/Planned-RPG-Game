using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCalculations {
	
	private int abilityPower;
	private int abilityWPPower;
	private float totalAbilityPowerDamage;
	private float totalAbilityWillpowerDamage;
	private int totalUsedAbilityDamage;
	private int totalUsedAbilityWillpowerDamage;
	private float totalCharacterDamage;
	private float totalWillpowerDamage;
	private int totalCritDamage;
	private int totalWPCritDamage;
	public GameObject newStatus;
	private BaseAbility characterUsedAbility;
	private bool willAbilityHit;
	private bool willStatusApply;
	private GameObject findGameInfo;
	private GameObject selfPanel;

	public void CalculateTotalDamage (BaseAbility usedAbility)
	{
		//need to account for when using a self targetting move (Take into account move's self apply status value, if the move does damage to the player or heals them, or removes statuses.)
		
		characterUsedAbility = usedAbility;
		Debug.Log("Used Ability: " + usedAbility.AbilityName);
		//move damage, critical effect, stat modifier, status effect
		totalUsedAbilityDamage = (int)CalculateAbilityDamage (usedAbility);
		totalUsedAbilityWillpowerDamage = (int)CalculateAbilityWillpowerDamage (usedAbility);
		//^^minus enemy defense calculation
		//if totalcharacterdamage <= 0, target.health.CurrentVal - totalCharacterDamage
		//else Debug.Log("Blocked")
		//StateMachine.currentState = StateMachine.BattleStates.ENEMYCHOICE;
		
		GameObject BattleManager = GameObject.Find("BattleManager");
		BattleGUI battleGUI = BattleManager.GetComponent<BattleGUI>();
		//possibleTargets = GameObject.FindGameObjectsWithTag("enemy");
		foreach (GameObject target in battleGUI.targets)
		{
			switch (target.tag)
			{
				case "enemy":
				int randomTemp = Random.Range (1,101);
				if (randomTemp <= usedAbility.AbilityAccuracy * (31 + GameInfo.info.Combat - target.GetComponent<BaseEnemy>().Agility))
				{
					Debug.Log("HIT!");
					willAbilityHit = true;
				} 
				else
				{
					willAbilityHit = false;
				}
				if (willAbilityHit)
				{
					totalCritDamage = CalculateCritDamage ();
					totalCharacterDamage = totalUsedAbilityDamage + totalCritDamage;
					target.GetComponent<CreateEnemy>().health.CurrentVal -= totalCharacterDamage;
					Debug.Log (totalCharacterDamage);
					if (usedAbility.WPDamagePower != 0)
					{
						totalWPCritDamage = CalculateWPCritDamage ();
						totalWillpowerDamage = totalUsedAbilityWillpowerDamage + totalWPCritDamage;
						target.GetComponent<CreateEnemy>().willpower.CurrentVal -= totalWillpowerDamage;
						Debug.Log("WP Damage: " + totalWillpowerDamage);
					}

					if (usedAbility.AbilityStatusEffects.Count > 0)
					{
						newStatus = target.transform.Find("statusIcons").gameObject;
						StatusManager statusManager = newStatus.GetComponent<StatusManager>();
						foreach (var singleStatus in usedAbility.AbilityStatusEffects)
						{
							if (statusManager.internalManager.currentStatus.Contains(singleStatus))
							{
								Debug.Log("Already has status");
							}
							else if (statusManager.internalManager.characterImmunities.Contains(singleStatus.StatusEffectName))
							{
								Debug.Log("Immune to status");
							}
							else
							{
								int randomTemp2 = Random.Range (1,101);
								if (randomTemp2 <= characterUsedAbility.StatusApplyChance * 100 + 5 * target.GetComponent<BaseEnemy>().Resistance)
								{
									statusManager.internalManager.currentStatus.Add(singleStatus);
									switch (singleStatus.StatusEffectID)
									{
										case 1:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.BLEEDING);
										break;
										case 2:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.BLINDED);
										break;
										case 3:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.CONFUSED);
										break;
										case 4:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.FALTERING);
										break;
										case 5:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.FEARPHOBIA);
										break;
										case 6:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.FEARING);
										break;
										case 7:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.FLYING);
										break;
										case 8:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.IMPOTENT);
										break;
										case 9:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.POISONEDDEADLY);
										break;
										case 10:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.POISONEDFAINTING);
										break;
										case 11:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.PRIMED);
										break;
										case 12:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.STUNNED);
										break;
										default:
										Debug.Log("Status not found!");
										break;
									}
									statusManager.ChangeIcons();
									Debug.Log("Apply status");
								} 
								else
								{
									Debug.Log("Status Avoided");
								}

							}
						}
					}
					//for all enemy attack
				}
				else
				{
					Debug.Log("MISS!");	
				}
				break;
				case "Player" :
				if (usedAbility.AbilityPower > 0)
				{
					GameObject createPlayer = GameObject.Find("CreatePlayer");
					CreateCharacter createCharacter = createPlayer.GetComponent<CreateCharacter>();
					createCharacter.health.CurrentVal -= usedAbility.AbilityPower * (GameInfo.info.InitialHealth / 25);
					Debug.Log("Damage to self");
				}
				if (usedAbility.AbilityPower < 0)
				{
					GameObject createPlayer = GameObject.Find("CreatePlayer");
					CreateCharacter createCharacter = createPlayer.GetComponent<CreateCharacter>();
					if (WillAbilityCrit())
					{
						createCharacter.health.CurrentVal -= usedAbility.AbilityPower * (int)(GameInfo.info.InitialHealth * 0.15);
						Debug.Log("Crit healed self");
					}
					else
					{
						createCharacter.health.CurrentVal -= usedAbility.AbilityPower * (int)(GameInfo.info.InitialHealth * 0.08);
						Debug.Log("Healed self");
					}
				}
				if (usedAbility.AbilityStatusEffects.Count > 0)
				{
				findGameInfo = GameObject.FindGameObjectWithTag("Player");
				selfPanel = findGameInfo.transform.Find("CharacterPanel").gameObject;
				newStatus = selfPanel.transform.Find("statusIcons").gameObject;
				StatusManager statusManager = newStatus.GetComponent<StatusManager>();
					foreach (var singleStatus in usedAbility.AbilityStatusEffects)
					{
						if (statusManager.internalManager.currentStatus.Contains(singleStatus) || GameInfo.characterImmunities.Contains(singleStatus))
						{
							Debug.Log("Already has status or immune");
						}
						else
						{
							int randomTemp2 = Random.Range (1,101);
							if (randomTemp2 <= characterUsedAbility.StatusApplyChance * 100 + 2 * GameInfo.info.Luck)
							{
								statusManager.internalManager.currentStatus.Add(singleStatus);
								switch (singleStatus.StatusEffectID)
								{
										case 1:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.BLEEDING);
										break;
										case 2:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.BLINDED);
										break;
										case 3:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.CONFUSED);
										break;
										case 4:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.FALTERING);
										break;
										case 5:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.FEARPHOBIA);
										break;
										case 6:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.FEARING);
										break;
										case 7:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.FLYING);
										break;
										case 8:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.IMPOTENT);
										break;
										case 9:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.POISONEDDEADLY);
										break;
										case 10:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.POISONEDFAINTING);
										break;
										case 11:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.PRIMED);
										break;
										case 12:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.STUNNED);
										break;
										default:
										Debug.Log("Status not found!");
										break;
								}
								statusManager.ChangeIcons();
								Debug.Log("Apply self status");
							} 
							else
							{
								Debug.Log("Self Status Failed");
							}

						}
					}
				}
				if (usedAbility.RemoveEffects.Count > 0)
				{
					findGameInfo = GameObject.FindGameObjectWithTag("Player");
					selfPanel = findGameInfo.transform.Find("CharacterPanel").gameObject;
					newStatus = selfPanel.transform.Find("statusIcons").gameObject;
					StatusManager statusManager = newStatus.GetComponent<StatusManager>();
					foreach (var removableStatus in usedAbility.RemoveEffects)
					{
						if (statusManager.internalManager.currentStatus.Contains(removableStatus))
						{
							int randomTemp2 = Random.Range (1,101);
							if (randomTemp2 <= characterUsedAbility.StatusApplyChance * 100 + GameInfo.info.Luck)
							{
								statusManager.internalManager.currentStatus.Remove(removableStatus);
								switch (removableStatus.StatusEffectID)
								{
										case 1:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.BLEEDING);
										break;
										case 2:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.BLINDED);
										break;
										case 3:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.CONFUSED);
										break;
										case 4:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.FALTERING);
										break;
										case 5:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.FEARPHOBIA);
										break;
										case 6:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.FEARING);
										break;
										case 7:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.FLYING);
										break;
										case 8:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.IMPOTENT);
										break;
										case 9:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.POISONEDDEADLY);
										break;
										case 10:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.POISONEDFAINTING);
										break;
										case 11:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.PRIMED);
										break;
										case 12:
										statusManager.internalManager.statusQueue.Add(InternalStatusManager.StatusType.STUNNED);
										break;
										default:
										Debug.Log("Status not found!");
										break;
								}
								statusManager.ChangeIcons();
								Debug.Log("Self removed status");
							} 
							else
							{
								Debug.Log("Self Removal Failed");
							}
						}
						else
						{
							Debug.Log("Not afflicted with " + removableStatus.StatusEffectName);
						}
					}
				}
				//Take into account if the move does damage to the player or heals them, or removes statuses.
				break;
			}
		}
		battleGUI.targets.Clear();
		StateMachine.moved = false;
		StateMachine.characterCompleteTurn = true;
	}
	
	private float CalculateAbilityDamage(BaseAbility usedAbility)
	{
		abilityPower = usedAbility.AbilityPower;
		if (abilityPower == 0)
		{
			totalAbilityPowerDamage = 0;
			return totalAbilityPowerDamage;
		}
		else
		{
			totalAbilityPowerDamage = GameInfo.info.Combat + 3 * abilityPower - 4;
			return totalAbilityPowerDamage;
		}
	}
	
	private int CalculateCritDamage()
	{
		if (WillAbilityCrit())
		{
			totalCritDamage = 0;
			return totalCritDamage = (int)totalAbilityPowerDamage / 2;
		}
		else
		{
			return totalCritDamage = 0;
		}
	}
	
	private float CalculateAbilityWillpowerDamage(BaseAbility usedAbility)
	{
		abilityWPPower = usedAbility.WPDamagePower;
		if (abilityWPPower == 0)
		{
			totalAbilityWillpowerDamage = 0;
			return totalAbilityWillpowerDamage;
		}
		else
		{
			totalAbilityWillpowerDamage = usedAbility.WPDamagePower;
			return totalAbilityWillpowerDamage;
		}
	}
	
	private int CalculateWPCritDamage ()
	{
		if (WillAbilityCrit())
		{
			totalWPCritDamage = 0;
			return totalWPCritDamage = (int)totalAbilityWillpowerDamage / 2;
		}
		else
		{
			return totalWPCritDamage = 0;
		}
	}
	
	private bool WillAbilityCrit()
	{
		int randomTemp = Random.Range (1,101);
		if (randomTemp <= characterUsedAbility.AbilityCritChance * GameInfo.info.Agility)
		{
			Debug.Log("CRIT!");
			return true;
		} 
		else
		{
			return false;
		}
	}
}









