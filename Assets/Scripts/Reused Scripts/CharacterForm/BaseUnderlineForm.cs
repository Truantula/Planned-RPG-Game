using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUnderlineForm : BaseForm {
	
	public BaseUnderlineForm () {
		characterFormName = "Underline";
		characterFormDescription = "It's said that long ago, a few lost cats managed to survive in these depths by surpassing their limits. Over generations, they became the Underline species, known for their high agility and mischievous tendencies.";
		Combat = 6;
		Mind = 6;
		Resistance = 6;
		Luck = 6;
		Agility = 12;
		InitialHealth = 90;
		InitialWillpower = 70;
	}
}