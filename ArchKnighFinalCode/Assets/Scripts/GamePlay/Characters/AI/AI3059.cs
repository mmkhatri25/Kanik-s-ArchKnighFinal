public class AI3059 : AIBase
{
	protected override void OnInit()
	{
		AddAction(new AIMove1007(m_Entity));
	}

	protected override void OnAIDeInit()
	{
	}

	private bool Conditions()
	{
		return GetIsAlive() && m_Entity.m_HatredTarget != null;
	}

	protected override void OnDeadBefore()
	{
		Divide(3060, 2);
	}
}
