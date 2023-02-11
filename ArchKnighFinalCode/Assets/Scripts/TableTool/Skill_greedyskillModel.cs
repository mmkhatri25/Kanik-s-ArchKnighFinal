namespace TableTool
{
	public class Skill_greedyskillModel : LocalModel<Skill_greedyskill, int>
	{
		private const string _Filename = "Skill_greedyskill";

		protected override string Filename => "Skill_greedyskill";

		protected override int GetBeanKey(Skill_greedyskill bean)
		{
			return bean.SkillID;
		}
	}
}
