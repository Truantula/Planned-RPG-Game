using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeldForm : BaseForm {
	
	public BaseWeldForm () {
		CharacterFormName = "Welded";
		CharacterFormDescription = "A being whose body has fused with unholy armor. The wearer's form inside the armor is obscured by a dark haze and it's unclear if their original body is still present. Presently all efforts to remove the armor have ended in utter failure.";
		Combat = 8;
		Mind = 6;
		Resistance = 7;
		Luck = 1;
		Agility = 4;
		InitialHealth = 100;
		InitialWillpower = 80;
	}
}