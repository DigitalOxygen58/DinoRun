using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class RatingApplication : MonoBehaviour
{
	[SerializeField]
	private Button[] starsButtons = new Button[5];
	private int amountSelectedStars;

	public Action onClickStar;

	void Start()
	{

		if (PlayerPrefs.GetInt("AmountStars") != 0)
		{
			for (int i = 0; i <= PlayerPrefs.GetInt("AmountStars"); i++)
			{
				starsButtons[i].GetComponent<Image>().color = Color.yellow;
			}
		}

		for (int i = 0; i < starsButtons.Length; i++)
		{
			int a = i;

			starsButtons[a].onClick.AddListener(() =>
			{
				amountSelectedStars = a;

				onClickStar?.Invoke();

				for (int j = 0; j <= a; j++)
				{
					starsButtons[j].GetComponent<Image>().color = Color.yellow;
				}

				for (int l = a + 1; l < starsButtons.Length; l++)
				{
					starsButtons[l].GetComponent<Image>().color = Color.white;
				}
			});
		}
	}

	private void OnEnable()
	{
		GetComponentInParent<PopupRateUs>().exitPopupRateUs += OpenGooglePlayService;
		GetComponentInParent<PopupRateUs>().exitPopupRateUs += OpenConnectPopUp;
	}

	private void OpenGooglePlayService()
	{
		if (amountSelectedStars > 2)
		{
			Debug.Log("Google");
			PlayerPrefs.SetInt("AmountStars", amountSelectedStars);

		}
	}

	private void OpenConnectPopUp()
	{
		if (amountSelectedStars < 3)
		{
			GetComponentInParent<SettingController>().popUpHelpAndSupport.SetActive(true);
			PlayerPrefs.SetInt("AmountStars", amountSelectedStars);

		}
	}
}
