using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHumanForm : BaseForm {
	
	public BaseHumanForm () {
		characterFormName = "Human";
		characterFormDescription = "Humans are the surface world's most technologically advanced species. They are not well received by others in the depths due to their general mismanagement of priorities and lack of survival skills.";
		Combat = 5;
		Mind = 8;
		Resistance = 6;
		Luck = 7;
		Agility = 6;
		InitialHealth = 90;
		InitialWillpower = 70;
		//CharacterAbilities.Add (new KnifeJab());
		//CharacterAbilities.Add (new PreciseCut());
	}
}