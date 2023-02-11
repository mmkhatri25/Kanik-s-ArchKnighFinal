namespace TableTool
{
	public class Stage_Level_chapter8Model : LocalModel<Stage_Level_chapter8, string>
	{
		private const string _Filename = "Stage_Level_chapter8";

		protected override string Filename => "Stage_Level_chapter8";

		protected override string GetBeanKey(Stage_Level_chapter8 bean)
		{
			return bean.RoomID;
		}
	}
}
