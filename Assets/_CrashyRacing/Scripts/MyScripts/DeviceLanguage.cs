using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class DeviceLanguage : MonoBehaviour
{
	public bool foreignMod = true;
	public bool spanishMod = false;

	private SystemLanguage[] arrayForeignLanguages = { SystemLanguage.English, SystemLanguage.Italian };
	private SystemLanguage[] arrayNativeLanguages = { SystemLanguage.Russian, SystemLanguage.Belarusian };

	void Start()
	{
		if (Application.systemLanguage == SystemLanguage.Spanish)
		{
			StartCoroutine(SetLocale(2));
		}
		else
		{
			foreach (SystemLanguage nativeLanguage in arrayNativeLanguages)
			{
				if (Application.systemLanguage == nativeLanguage)
				{
					StartCoroutine(SetLocale(1));
					break;
				}
			}

			foreach (SystemLanguage foreignLanguage in arrayForeignLanguages)
			{
				if (Application.systemLanguage == foreignLanguage)
				{
					StartCoroutine(SetLocale(0));
					break;
				}
			}
		}
	}

	public IEnumerator SetLocale(int iDLanguage)
	{
		yield return LocalizationSettings.InitializationOperation;
		LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[iDLanguage];
	}

}
