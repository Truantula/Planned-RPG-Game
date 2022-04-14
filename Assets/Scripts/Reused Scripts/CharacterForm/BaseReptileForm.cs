using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseReptileForm : BaseForm {
	
	public BaseReptileForm () {
		CharacterFormName = "Reptilian";
		CharacterFormDescription = "Reptilians are unique even among themselves. They are created by a living vessel's DNA being overwritten through multiple infusions of reptile DNA present in venom and saliva. Instead of the being's body rejecting the venom, it may submit and allow a combination of physical traits from the reptiles to take root. Those with decreased fighting spirits at the time of exposure are more susceptible to this reaction.";
		Combat = 8;
		Mind = 6;
		Resistance = 8;
		Luck = 8;
		Agility = 8;
		InitialHealth = 100;
		InitialWillpower = 80;
		//CharacterAbilities.Add (new KnifeJab());
		//CharacterAbilities.Add (new Bite());
		//CharacterAbilities.Add (new Tail());
	}
}