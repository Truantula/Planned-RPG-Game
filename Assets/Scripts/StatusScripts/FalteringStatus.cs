[System.Serializable]

public class FalteringStatus : BaseStatusEffect{

	public FalteringStatus()
	{
		StatusEffectName = "Faltering";
		StatusEffectDescription = "Attacking and defending are harder to do correctly.";
		StatusEffectID = 4;
		IfTurnDuration = false;
		IfPercentage = true;
		BasePercentFluct = -15;
		VariantMinorName = "(minor)";
		MinorBound = 0.0f;
		VariantMajorName = "(unreliable)";
		MajorBound = 0.33f;
		VariantExtremeName = "(incapable)";
		ExtremeBound = 0.66f;
		IfEffectOnHundred = false;
		IfEffectOnZero = false;
		RemainAfterBattle = false;
		RemoveWhenInjured = false;
	}	
}
