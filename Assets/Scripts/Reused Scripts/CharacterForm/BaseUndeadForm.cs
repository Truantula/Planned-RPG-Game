using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUndeadForm : BaseForm {

	public BaseUndeadForm () {
		characterFormName = "Undead";
		characterFormDescription = "There are instances when an individual's will is strong enough to delay the death of the spirit. That is when one becomes Undead; those who no longer restricted by neither their past flesh or blood.";
		Combat = 6;
		Mind = 6;
		Resistance = 3;
		Luck = 5;
		Agility = 6;
		InitialHealth = 70;
		InitialWillpower = 60;
	}
}
