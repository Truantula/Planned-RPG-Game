using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour {

	[SerializeField]
	public Stat health;
	
	[SerializeField]
	public Stat willpower;
	
	private BaseEnemy baseEnemy;
	
	private void Awake()
	{
		health.Initialize();
		willpower.Initialize();
		baseEnemy = GetComponent<BaseEnemy>();
		/*switch (baseEnemy.enemyFormName)
		{
			case ("Goblin"):
			baseEnemy.enemyMoves.Add(new Pummel());
			baseEnemy.enemyMoves.Add(new Fire());
			baseEnemy.enemyMoves.Add(new Regenerate());
				break;
		}*/
	}
		
	public void Initialize()
	{
		health.MaxVal = health.maxVal;
		health.CurrentVal = health.currentVal;
		willpower.MaxVal = willpower.maxVal;
		willpower.CurrentVal = willpower.currentVal;
	}
	
	public void TakeDamage(int amount)
	{
		health.CurrentVal -= amount;
	}
	public void TakeWPDamage(int amount)
	{
		willpower.CurrentVal -= amount;
	}	
}
