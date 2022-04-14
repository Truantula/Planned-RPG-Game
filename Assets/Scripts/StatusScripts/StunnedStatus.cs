[System.Serializable]

public class StunnedStatus : BaseStatusEffect{

	public StunnedStatus()
	{
		StatusEffectName = "Stun";
		StatusEffectDescription = "One is unable to act for a short time";
		StatusEffectID = 12;
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
		RemoveWhenInjured = false;
	}	
}
