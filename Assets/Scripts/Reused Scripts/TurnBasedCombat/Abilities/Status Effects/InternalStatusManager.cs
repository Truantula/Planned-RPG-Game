using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InternalStatusManager {

	//public float BouncyDuration { get; set; } // rapid's duration
    //public float StraightShooterDuration { get; set; } // rapid's duration
    //public float SlowMoDuration { get; set; } // rapid's duration
    
    public enum StatusType 
	{
         NULL, POISONEDFAINTING, POISONEDDEADLY, CONFUSED, BLEEDING, BLINDED, PRIMED, FLYING, IMPOTENT, STUNNED, FALTERING, FEARING, FEARPHOBIA
    }
 
    public List<BaseStatusEffect> currentStatus = new List<BaseStatusEffect>();
	public List<string> characterImmunities = new List<string>();
	public List<StatusType> statusQueue = new List<StatusType>();
	public StatusType GetStatus(int index) {
        if(statusQueue.Count == 0) 
			return StatusType.NULL;
        if(index >= statusQueue.Count) 
			return StatusType.NULL;
        return statusQueue[index];
    }
	
	/*public enum SpurType
	{
		NULL, CURSED, BLESSED, EASYPREY, GOLDRUSH, STEADFAST, VILLAINOUS, TUNNELSTAR, REVERED
	}
	
	public List<SpurType> spurQueue = new List<SpurType>();
	public SpurType GetSpur(int index) {
		if(spurQueue.Count == 0) 
			return SpurType.NULL;
		if(index >= spurQueue.Count) 
			return SpurType.NULL;
        return spurQueue[index];
	}*/
	
	
	
	
	
}
