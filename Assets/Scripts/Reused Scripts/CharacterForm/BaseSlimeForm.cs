using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSlimeForm : BaseForm {

	public BaseSlimeForm () {
		characterFormName = "Slime";
		characterFormDescription = "Through their defeat at the hands of a malevolent creature, Slimes are those whose bodies have been thoroughly corrupted by the creature's festering saliva.";
		Combat = 4;
		Mind = 2;
		Resistance = 8;
		Luck = 6;
		Agility = 3;
		InitialHealth = 90;
		InitialWillpower = 70;
	}
}