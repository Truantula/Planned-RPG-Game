[System.Serializable]

public class ConfusedStatus : BaseStatusEffect{

	public ConfusedStatus()
	{
		StatusEffectName = "Confused";
		StatusEffectDescription = "It's hard to think staight....Actions are out of one's control.";
		StatusEffectID = 3;
		IfTurnDuration = true;
		IfPercentage = false;
		BasePercentFluct = 0;
		VariantMinorName = "(concussed)";
		MinorBound = 1.0f;
		VariantMajorName = "(dull stupor)";
		MajorBound = 1.0f;
		VariantExtremeName = "(berserk)";
		ExtremeBound = 1.0f;
		IfEffectOnHundred = false;
		IfEffectOnZero = false;
		RemainAfterBattle = false;//maybe true for (dull stupor)
		RemoveWhenInjured = true;
	}	
}
