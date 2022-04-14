[System.Serializable]

public class FlyingStatus : BaseStatusEffect{

	public FlyingStatus()
	{
		StatusEffectName = "Flight";
		StatusEffectDescription = "Soaring above enemies, one is harder to hit, but taking an attack causes a crash.";
		StatusEffectID = 7;
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
