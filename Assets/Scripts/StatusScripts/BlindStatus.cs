[System.Serializable]

public class BlindStatus : BaseStatusEffect{

	public BlindStatus()
	{
		StatusEffectName = "Blinded";
		StatusEffectDescription = "Irritation of the eyes causes a temporary drop in accuracy.";
		StatusEffectID = 2;
		IfTurnDuration = false;
		IfPercentage = false;
		BasePercentFluct = 0;
		VariantMinorName = "teary";
		MinorBound = 1.0f;
		VariantMajorName = "burning";
		MajorBound = 1.0f;
		VariantExtremeName = "darkness";
		ExtremeBound = 1.0f;
		IfEffectOnHundred = false;
		IfEffectOnZero = false;
		RemainAfterBattle = false;
		RemoveWhenInjured = false;
	}	
}
