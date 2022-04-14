using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSerfinForm : BaseForm {

	public BaseSerfinForm () {
		characterFormName = "Serfin";
		characterFormDescription = "In the distant past when the depths were nothing but caverns inundated with water, Serfins were plentiful, dominating all sreas of society, but now find themselves an endangered species due to declining water levels and cannibalism. Many remaining bodies of water in the depths are home to Serfin.";
		Combat = 6;
		Mind = 6;
		Resistance = 6;
		Luck = 7;
		Agility = 6;
		InitialHealth = 90;
		InitialWillpower = 70;
	}
}