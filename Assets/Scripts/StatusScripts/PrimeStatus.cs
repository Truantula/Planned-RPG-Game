[System.Serializable]

public class PrimeStatus : BaseStatusEffect{

	public PrimeStatus()
	{
		StatusEffectName = "Primed";
		StatusEffectDescription = "A short-lived surge of energy allows for a single, extra deadly attack. This energy can be lost upon taking damage.";
		StatusEffectID = 11;
		IfTurnDuration = false;
		IfPercentage = false;
		BasePercentFluct = 0;
		VariantMinorName = null;
		MinorBound = 0f;
		VariantMajorName = null;
		MajorBound = 0f;
		VariantExtremeName = null;
		ExtremeBound = 0f;
		IfEffectOnHundred = false;
		IfEffectOnZero = false;
		RemainAfterBattle = false;
		RemoveWhenInjured = true;
	}	
}
