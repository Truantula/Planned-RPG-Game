[System.Serializable]

public class ImpotentStatus : BaseStatusEffect{

	public ImpotentStatus()
	{
		StatusEffectName = "Impotent";
		StatusEffectDescription = "Can't muster any power into physical attacks for a short while.";
		StatusEffectID = 8;
		IfTurnDuration = true;
		IfPercentage = false;
		BasePercentFluct = 1;
		VariantMinorName = null;
		MinorBound = 0f;
		VariantMajorName = null;
		MajorBound = 0f;
		VariantExtremeName = null;
		ExtremeBound = 0f;
		IfEffectOnHundred = false;
		IfEffectOnZero = false;
		RemainAfterBattle = false;
		RemoveWhenInjured = false;
	}	
}
