using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamerAlly : BaseAlly
{
	public DreamerAlly () {
		allyName = "Dreamer";
		allyFormName = "Goblin";
		allyDescription = "A goblin who wishes to explore the unknown.";
		Combat = 4;
		Mind = 4;
		Resistance = 5;
		Luck = 6;
		Agility = 4;
		InitialHealth = 30;
		InitialWillpower = 40;
	}
}