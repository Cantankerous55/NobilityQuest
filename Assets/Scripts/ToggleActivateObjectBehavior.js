#pragma strict

public var itemToToggle:GameObject;
public var isActive:boolean;

function Start():void
{

}

function OnTriggerEnter (other:Collider):void
{
	if (isActive == true)
	{
		itemToToggle.SetActive(true);
		Debug.Log("Activating.");
	}
	else
	{
		itemToToggle.SetActive(false);
		Debug.Log("Deactivating.");
	}
}