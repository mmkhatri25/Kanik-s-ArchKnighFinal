public class SkillAlone1062 : SkillAloneBase
{
	protected override void OnInstall()
	{
		m_Entity.m_EntityData.Modify_BabyResistBullet(1);
	}

	protected override void OnUninstall()
	{
		m_Entity.m_EntityData.Modify_BabyResistBullet(-1);
	}
}
