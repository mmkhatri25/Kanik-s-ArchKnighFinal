namespace TableTool
{
	public class Fx_fxModel : LocalModel<Fx_fx, int>
	{
		private const string _Filename = "Fx_fx";

		protected override string Filename => "Fx_fx";

		protected override int GetBeanKey(Fx_fx bean)
		{
			return bean.FxID;
		}
	}
}
