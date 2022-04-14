[System.Serializable]

public class PoisonFaintStatus : BaseStatusEffect{

	public PoisonFaintStatus()
	{
		StatusEffectName = "Poisoned ";
		StatusEffectDescription = "A foreign substance is attacking the immune system, causing negative effects based on the poison's origin.";
		StatusEffectID = 10;
		IfTurnDuration = false;
		IfPercentage = true;
		BasePercentFluct = 3;
		VariantMinorName = "(initial)";
		MinorBound = 0.0f;
		VariantMajorName = "(woozy)";
		MajorBound = 0.5f;
		VariantExtremeName = null;
		ExtremeBound = 1.0f;
		IfEffectOnHundred = true;
		IfEffectOnZero = false;
		RemainAfterBattle = true;
		RemoveWhenInjured = false;
	}	
}
