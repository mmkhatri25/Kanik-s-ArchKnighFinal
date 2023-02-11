using Dxx.Util;
using UnityEngine;
using UnityEngine.UI;

public class LayerRewardOneCtrl : MonoBehaviour
{
	public Image Image_Icon;

	public Text Text_Count;

	public Text Text_Content;

	public int id;

	public void Init(int id, int count)
	{
        if (id == 3)
            this.gameObject.SetActive(false);
        if (id == 3)
            return;
		this.id = id;
		Text_Content.text = string.Empty;
		Image_Icon.enabled = false;
		Text_Count.text = Utils.FormatString("x{0}", count);
		if (id == 4)
		{
			Text_Content.text = GameLogic.Hold.Language.GetLanguageByTID("currency_reborn");
			return;
		}
		Image_Icon.enabled = true;
		Image_Icon.sprite = SpriteManager.GetUICommonCurrency((CurrencyType)id);
        this.gameObject.transform.position = new Vector3(0, this.transform.position.y, this.transform.position.z);
	}
}
