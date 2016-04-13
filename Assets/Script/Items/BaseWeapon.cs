using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseItem {

	public int level;

	public enum WeaponType{
		WiiU,
		PS4,
		XBox,
		Keyboard,
		Mic,
		Book,
		Internet
	};

	public WeaponType weapontype;
}
