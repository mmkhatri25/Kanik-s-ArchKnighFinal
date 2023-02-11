namespace TableTool
{
	public class Skill_slotfirstModel : LocalModel<Skill_slotfirst, int>
	{
		private const string _Filename = "Skill_slotfirst";

		protected override string Filename => "Skill_slotfirst";

		protected override int GetBeanKey(Skill_slotfirst bean)
		{
			return bean.SkillID;
		}
	}
}
