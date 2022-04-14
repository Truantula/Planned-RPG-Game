[System.Serializable]

public class FearPhobiaStatus : BaseStatusEffect{

	public FearPhobiaStatus()
	{
		StatusEffectName = "Fear";
		StatusEffectDescription = "The desire to avoid a certain creature is weighing heavily the mind, causing a drop in resilience and willpower.";
		StatusEffectID = 5;
		IfTurnDuration = false;
		IfPercentage = false;
		BasePercentFluct = 0;
		VariantMinorName = "(phobia)";
		MinorBound = 1.0f;
		VariantMajorName = null;
		MajorBound = 2.0f;
		VariantExtremeName = null;
		ExtremeBound = 2.0f;
		IfEffectOnHundred = false;
		IfEffectOnZero = false;
		RemainAfterBattle = false;
		RemoveWhenInjured = false;
	}	
}
