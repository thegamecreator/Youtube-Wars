using UnityEngine;
using System.Collections;

public class BaseItem : MonoBehaviour {

	public int itemid;
	public string iname;
	public string desp;
	public enum itemType{
		potion,
		weapon,
		armor,
		tube
	};
	public itemType ItemType;
}
