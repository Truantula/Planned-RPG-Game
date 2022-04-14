[System.Serializable]

public class BleedStatus : BaseStatusEffect{

	public BleedStatus()
	{
		StatusEffectName = "Bleed";
		StatusEffectDescription = "Blood still runs from an injury. Weakens the body at higher intensities, and at its max, causes unconsciousness";
		StatusEffectID = 1;
		IfTurnDuration = false;
		IfPercentage = true;
		BasePercentFluct = -8;
		VariantMinorName = "(minor)";
		MinorBound = 0.0f;
		VariantMajorName = "(moderate)";
		MajorBound = 0.29f;
		VariantExtremeName = "(severe)";
		ExtremeBound = 0.69f;
		IfEffectOnHundred = true;
		IfEffectOnZero = false;
		RemainAfterBattle = true;
		RemoveWhenInjured = false;
	}	
}
