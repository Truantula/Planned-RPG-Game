[System.Serializable]

public class FearStatus : BaseStatusEffect{

	public FearStatus()
	{
		StatusEffectName = "Fear";
		StatusEffectDescription = "The desire to escape the threat is weighing heavily the mind, causing a drop in resilience and willpower.";
		StatusEffectID = 6;
		IfTurnDuration = true;
		IfPercentage = false;
		BasePercentFluct = 0;
		VariantMinorName = "(threatened)";
		MinorBound = 1.0f;
		VariantMajorName = "(awed)";
		MajorBound = 1.0f;
		VariantExtremeName = null;
		ExtremeBound = 1.0f;
		IfEffectOnHundred = false;
		IfEffectOnZero = false;
		RemainAfterBattle = false;
		RemoveWhenInjured = false;
	}	
}
