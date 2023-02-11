using UnityEngine;
using UnityEngine.UI;

public class StageListContinueCtrl : MonoBehaviour
{
	public Text Text_Content;

	public void OnLanguageChange()
	{
		Text_Content.text = GameLogic.Hold.Language.GetLanguageByTID("Main_CommingSoon");
	}
}
