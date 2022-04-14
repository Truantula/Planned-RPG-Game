using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : BaseEnemy {

	public Goblin () {
		enemyFormName = "Goblin";
		enemyFormDescription = "A hunched, green weirdo.";
		Combat = 3;
		Mind = 5;
		Resistance = 5;
		Luck = 4;
		Agility = 6;
		InitialHealth = 50;
		InitialWillpower = 10;
	}
}
