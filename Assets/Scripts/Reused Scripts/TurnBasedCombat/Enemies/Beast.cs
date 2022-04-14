using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WildBeast : BaseEnemy {

	public WildBeast () {
		enemyFormName = "Wild Beast";
		enemyFormDescription = "A hairy, smelly creature.";
		Combat = 5;
		Mind = 2;
		Resistance = 6;
		Luck = 5;
		Agility = 6;
		InitialHealth = 70;
		InitialWillpower = 20;
	}
}