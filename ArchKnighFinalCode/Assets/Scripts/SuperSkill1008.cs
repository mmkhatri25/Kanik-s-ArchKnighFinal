public class SuperSkill1008 : SuperSkillBase
{
	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnUseSkill()
	{
		GameLogic.SendBuff(base.m_Entity, 1027);
	}
}
