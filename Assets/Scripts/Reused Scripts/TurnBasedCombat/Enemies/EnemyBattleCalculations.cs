using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBattleCalculations {

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
	
	public void EnemyCalculateTotalDamage (BaseAbility usedAbility)
	{
		characterUsedAbility = usedAbility;
		Debug.Log("Used Ability: " + usedAbility.AbilityName);
		totalUsedAbilityDamage = (int)CalculateAbilityDamage (usedAbility);
		totalUsedAbilityWillpowerDamage = (int)CalculateAbilityWillpowerDamage (usedAbility);
		GameObject BattleManager = GameObject.Find("BattleManager");
		BattleGUI battleGUI = BattleManager.GetComponent<BattleGUI>();
		foreach (GameObject target in battleGUI.targets)
		{
			switch (target.tag)
			{
				case "Player":
				int randomTemp = Random.Range (1,101);
				if (randomTemp <= usedAbility.AbilityAccuracy * (31 + BattleStateEnemyChoice.actingEnemy.GetComponent<BaseEnemy>().Combat - GameInfo.info.Agility))
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
					GameObject createPlayer = GameObject.Find("CreatePlayer");
					CreateCharacter createCharacter = createPlayer.GetComponent<CreateCharacter>();
					totalCritDamage = CalculateCritDamage ();
					totalCharacterDamage = totalUsedAbilityDamage + totalCritDamage;
					createCharacter.health.CurrentVal -= totalCharacterDamage;
					Debug.Log ("Enemy damage to Player: " + totalCharacterDamage);
					if (usedAbility.WPDamagePower != 0)
					{
						totalWPCritDamage = CalculateWPCritDamage ();
						totalWillpowerDamage = totalUsedAbilityWillpowerDamage + totalWPCritDamage;
						createCharacter.willpower.CurrentVal -= totalWillpowerDamage;
						Debug.Log("WP Damage to Player: " + totalWillpowerDamage);
					}

					if (usedAbility.AbilityStatusEffects.Count > 0)
					{
						findGameInfo = GameObject.FindGameObjectWithTag("Player");
						selfPanel = findGameInfo.transform.Find("CharacterPanel").gameObject;
						newStatus = selfPanel.transform.Find("statusIcons").gameObject;
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
								if (randomTemp2 <= characterUsedAbility.StatusApplyChance * 100 + 5 * (BattleStateEnemyChoice.actingEnemy.GetComponent<BaseEnemy>().Luck - GameInfo.info.Luck))
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
				
				case "enemy":
				if (usedAbility.AbilityPower > 0)
				{
					BattleStateEnemyChoice.actingEnemy.GetComponent<CreateEnemy>().health.CurrentVal -= usedAbility.AbilityPower * (BattleStateEnemyChoice.actingEnemy.GetComponent<CreateEnemy>().health.MaxVal / 25);
					Debug.Log("Enemy damage to self");
				}
				if (usedAbility.AbilityPower < 0)
				{
					if (WillAbilityCrit())
					{
						BattleStateEnemyChoice.actingEnemy.GetComponent<CreateEnemy>().health.CurrentVal -= usedAbility.AbilityPower * (int)(BattleStateEnemyChoice.actingEnemy.GetComponent<CreateEnemy>().health.MaxVal * 0.15);
						Debug.Log("Enemy crit healed self");
					}
					else
					{
						BattleStateEnemyChoice.actingEnemy.GetComponent<CreateEnemy>().health.CurrentVal -= usedAbility.AbilityPower * (int)(BattleStateEnemyChoice.actingEnemy.GetComponent<CreateEnemy>().health.MaxVal * 0.08);
						Debug.Log("Enemy healed self");
					}
				}
				if (usedAbility.AbilityStatusEffects.Count > 0)
				{
					newStatus = BattleStateEnemyChoice.actingEnemy.transform.Find("statusIcons").gameObject;
					StatusManager statusManager = newStatus.GetComponent<StatusManager>();
					foreach (var singleStatus in usedAbility.AbilityStatusEffects)
					{
						if (statusManager.internalManager.currentStatus.Contains(singleStatus) || statusManager.internalManager.characterImmunities.Contains(singleStatus.StatusEffectName))
						{
							Debug.Log("Already has status or immune");
						}
						else
						{
							int randomTemp2 = Random.Range (1,101);
							if (randomTemp2 <= characterUsedAbility.StatusApplyChance * 100 + 2 * BattleStateEnemyChoice.actingEnemy.GetComponent<BaseEnemy>().Luck)
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
								Debug.Log("Apply enemy self status");
							} 
							else
							{
								Debug.Log("Self enemy Status Failed");
							}

						}
					}
				}
				if (usedAbility.RemoveEffects.Count > 0)
				{
					newStatus = BattleStateEnemyChoice.actingEnemy.transform.Find("statusIcons").gameObject;
					StatusManager statusManager = newStatus.GetComponent<StatusManager>();
					foreach (var removableStatus in usedAbility.RemoveEffects)
					{
						if (statusManager.internalManager.currentStatus.Contains(removableStatus))
						{
							int randomTemp2 = Random.Range (1,101);
							if (randomTemp2 <= characterUsedAbility.StatusApplyChance * 100 + BattleStateEnemyChoice.actingEnemy.GetComponent<BaseEnemy>().Luck)
							{
								statusManager.internalManager.currentStatus.Remove(removableStatus);
								/*switch (removableStatus.StatusEffectID)
								{
									case 1:
									statusManager.internalManager.statusQueue.Remove(InternalStatusManager.StatusType.BLEEDING);
									break;
									case 2:
									statusManager.internalManager.statusQueue.Remove(InternalStatusManager.StatusType.RECOVERING);
									break;
									case 3:
									statusManager.internalManager.statusQueue.Remove(InternalStatusManager.StatusType.POISONED);
									break;
									case 4:
									statusManager.internalManager.statusQueue.Remove(InternalStatusManager.StatusType.BLINDED);
									break;
									case 5:
									statusManager.internalManager.statusQueue.Remove(InternalStatusManager.StatusType.ENFLAMED);
									break;
									case 6:
									statusManager.internalManager.statusQueue.Remove(InternalStatusManager.StatusType.WEAK);
									break;
									case 7:
									statusManager.internalManager.statusQueue.Remove(InternalStatusManager.StatusType.POWERFUL);
									break;
									case 8:
									statusManager.internalManager.statusQueue.Remove(InternalStatusManager.StatusType.RESISTANT);
									break;
									case 9:
									statusManager.internalManager.statusQueue.Remove(InternalStatusManager.StatusType.VULNERABLE);
									break;
									case 10:
									statusManager.internalManager.statusQueue.Remove(InternalStatusManager.StatusType.FRAIL);
									break;
									case 11:
									statusManager.internalManager.statusQueue.Remove(InternalStatusManager.StatusType.TOUGH);
									break;
									case 12:
									statusManager.internalManager.statusQueue.Remove(InternalStatusManager.StatusType.IMPOTENT);
									break;
									case 13:
									statusManager.internalManager.statusQueue.Remove(InternalStatusManager.StatusType.FLYING);
									break;
									default:
									Debug.Log("Status not found!");
									break;
								}*/
								statusManager.ChangeIcons();
								Debug.Log("Enemy self removed status");
							} 
							else
							{
								Debug.Log("Enemy self Removal Failed");
							}
						}
						else
						{
							Debug.Log("Enemy not afflicted with " + removableStatus.StatusEffectName);
						}
					}
				}
				break;
			}
		}
		battleGUI.targets.Clear();
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
			totalAbilityPowerDamage = BattleStateEnemyChoice.actingEnemy.GetComponent<BaseEnemy>().Combat + 3 * abilityPower - 4;
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
		if (randomTemp <= characterUsedAbility.AbilityCritChance * BattleStateEnemyChoice.actingEnemy.GetComponent<BaseEnemy>().Luck)
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
