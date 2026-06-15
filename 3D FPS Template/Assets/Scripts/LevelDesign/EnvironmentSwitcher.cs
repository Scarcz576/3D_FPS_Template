using UnityEngine;

public class EnvironmentSwitcher : Interactable
{
	public Transform environmentCurrent;
	public Transform environmentSwitch;
	public bool switched;
	
	
	public override void Interact(Collider player)
	{
		base.Interact(player);
		if (switched)
			return;
			
		switched = true;
		
		environmentCurrent?.gameObject.SetActive(false);
		environmentSwitch?.gameObject.SetActive(true);
	
	}
	
	
	
	
    
    
}
