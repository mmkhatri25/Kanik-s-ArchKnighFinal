public class SkillAlone1008 : SkillAloneBase
{
	protected override void OnInstall()
	{
		m_Entity.m_EntityData.Modify_FlyWater(1);
	}

	protected override void OnUninstall()
	{
		m_Entity.m_EntityData.Modify_FlyWater(-1);
	}
}
