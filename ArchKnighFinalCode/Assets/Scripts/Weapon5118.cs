using Dxx.Util;
using UnityEngine;

public class Weapon5118 : WeaponBase
{
	protected override void OnInstall()
	{
	}

	protected override void OnUnInstall()
	{
	}

	protected override void OnAttack(object[] args)
	{
		int num = 4;
		for (int i = 0; i < num; i++)
		{
			CreateBulletOverride(Vector3.zero, Utils.GetBulletAngle(i, num, 90f));
		}
	}
}
