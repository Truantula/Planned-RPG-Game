using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAvenForm : BaseForm {

	public BaseAvenForm () {
		characterFormName = "Aven";
		characterFormDescription = "Avens are winged creatures typically found in large groups of ten or more that feed on depths plant life and insects. Avens that stray from their flock are often attacked, as most creatures wouldn't pass on an easy opportunity at the well-known succulence of Aven meat";
		Combat = 5;
		Mind = 6;
		Resistance = 7;
		Luck = 6;
		Agility = 8;
		InitialHealth = 90;
		InitialWillpower = 70;
	}
}