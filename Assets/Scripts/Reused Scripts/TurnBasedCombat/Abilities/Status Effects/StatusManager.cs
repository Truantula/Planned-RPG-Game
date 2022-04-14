using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusManager : MonoBehaviour {

	public GameObject[] statusIcons;
	public GameObject spurIcon;
	public InternalStatusManager internalManager = new InternalStatusManager();
	
	public Sprite Null;
	public Sprite PoisonedIcon;
	public Sprite StunnedIcon;
	//public Sprite CursedIcon;
	//public Sprite BlessedIcon;
	//public Sprite GoldrushIcon;
	//public Sprite EasypreyIcon;
	//public Sprite SteadfastIcon;
	//public Sprite VillainousIcon;
	//public Sprite TunnelstarIcon;
	//public Sprite ReveredIcon;
	public Sprite ConfusedIcon;
	public Sprite FalteringIcon;
	//public Sprite VulnerableIcon;
	//public Sprite HeroicIcon;
	//public Sprite CatharticIcon;
	public Sprite BleedingIcon;
	//public Sprite RecoveringIcon;
	public Sprite BlindedIcon;
	public Sprite PrimedIcon;
	public Sprite FlyingIcon;
	public Sprite ImpotentIcon;
	public Sprite FearingIcon;
	
	void Start()
	{
		//internalManager.statusQueue.Add(InternalStatusManager.StatusType.VILED);
		//internalManager.statusQueue.Add(InternalStatusManager.StatusType.MUSCLE);
		//ChangeIcons();
		//works
		
		//GameObject icon = GameObject.Find("status1");
		//icon.GetComponent<SpriteRenderer>().sprite = ViledIcon;
			//works
	}

public void ChangeIcons()
	{
         
        for(int i = 0; i <= internalManager.statusQueue.Count; ++i) 
        {
            if(internalManager.GetStatus(i) == InternalStatusManager.StatusType.NULL)
            {
                 statusIcons[i].GetComponent<Image>().sprite = Null;
            }
             
            switch(internalManager.GetStatus(i))
            {
            case InternalStatusManager.StatusType.BLEEDING:
                statusIcons[i].GetComponent<Image>().sprite = BleedingIcon;
                break;
                 
            case InternalStatusManager.StatusType.BLINDED:
                statusIcons[i].GetComponent<Image>().sprite = BlindedIcon;
                break;
                 
            case InternalStatusManager.StatusType.CONFUSED:
                statusIcons[i].GetComponent<Image>().sprite = ConfusedIcon;
                break;
			
			case InternalStatusManager.StatusType.FEARING:
                statusIcons[i].GetComponent<Image>().sprite = FalteringIcon;
                break;
                 
            case InternalStatusManager.StatusType.FEARPHOBIA:
                statusIcons[i].GetComponent<Image>().sprite = FearingIcon;
                break;
                 
            case InternalStatusManager.StatusType.FALTERING:
                statusIcons[i].GetComponent<Image>().sprite = FearingIcon;
                break;
				
			case InternalStatusManager.StatusType.FLYING:
                statusIcons[i].GetComponent<Image>().sprite = FlyingIcon;
                break;
                 
            case InternalStatusManager.StatusType.IMPOTENT:
                statusIcons[i].GetComponent<Image>().sprite = ImpotentIcon;
                break;
                 
            case InternalStatusManager.StatusType.POISONEDDEADLY:
                statusIcons[i].GetComponent<Image>().sprite = PoisonedIcon;
                break;
				
			case InternalStatusManager.StatusType.POISONEDFAINTING:
                statusIcons[i].GetComponent<Image>().sprite = PoisonedIcon;
                break;
                 
            case InternalStatusManager.StatusType.PRIMED:
                statusIcons[i].GetComponent<Image>().sprite = PrimedIcon;
                break;
                 
			case InternalStatusManager.StatusType.STUNNED:
                statusIcons[i].GetComponent<Image>().sprite = StunnedIcon;
                break;
                 
            }
        }
 
    }
	
/*public void ChangeSpurIcon()
	{
		for(int i = 0; i <= internalManager.spurQueue.Count; ++i) 
        {
            if(internalManager.spurQueue.Count > 1)
            {
                 internalManager.spurQueue.RemoveAt(0);
            }
			
			if(internalManager.spurQueue.Count == 0)
			{
				spurIcon.GetComponent<Image>().sprite = Null;
			}
             
            switch(internalManager.GetSpur(i))
            {
    
            case InternalStatusManager.SpurType.CURSED:
                spurIcon.GetComponent<Image>().sprite = CursedIcon;
                break;
                 
            case InternalStatusManager.SpurType.BLESSED:
                spurIcon.GetComponent<Image>().sprite = BlessedIcon;
                break;
				
			case InternalStatusManager.SpurType.EASYPREY:
                spurIcon.GetComponent<Image>().sprite = EasypreyIcon;
                break;
				
			case InternalStatusManager.SpurType.GOLDRUSH:
                spurIcon.GetComponent<Image>().sprite = GoldrushIcon;
                break;
				
			case InternalStatusManager.SpurType.STEADFAST:
                spurIcon.GetComponent<Image>().sprite = SteadfastIcon;
                break;
				
			case InternalStatusManager.SpurType.VILLAINOUS:
                spurIcon.GetComponent<Image>().sprite = VillainousIcon;
                break;
				
			case InternalStatusManager.SpurType.TUNNELSTAR:
                spurIcon.GetComponent<Image>().sprite = TunnelstarIcon;
                break;
				
			case InternalStatusManager.SpurType.REVERED:
                spurIcon.GetComponent<Image>().sprite = ReveredIcon;
                break;
            }
        }
		Debug.Log(internalManager.spurQueue.Count);
	}*/
	
 }
