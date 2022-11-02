using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class CountrySelector : MonoBehaviour
{
	public UnityEvent<CountryData> OnCountrySelected = new UnityEvent<CountryData>();

    public CountryData[] countryData;
    public GameObject countryPref;

	[SerializeField]
    private Country countryPrefab;
	[SerializeField]
	private ScrollRect scrollRect;

    private List<Country> countries = new List<Country>();

	private void Awake()
	{
		AddCountries();
	}

	//private void SpawnCountry()
	//{
	//	for (int i = 0; i < countryData.Length; i++)
	//	{
	//		GameObject newCountry= Instantiate(countryPref, transform);
 //           newCountry.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = countryData[i].countryName;
 //           newCountry.transform.GetChild(1).GetComponent<Image>().sprite = countryData[i].countryFlag?.sprite;
 //           newCountry.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = countryData[i].countryShopURL;
	//	}
 //   }

    public void AddCountries()
	{
		foreach (var data in countryData)
		{
			Country country = Instantiate(countryPrefab, scrollRect.content);
			countries.Add(country);
			country.Initialize(data);
			country.OnCountrySelected.AddListener((item) => OnCountrySelected?.Invoke(item.countryData));
		}
	}

	public void RemoveCountrires()
	{
		while (countries.Count > 0)
		{
			Destroy(countries[0].gameObject);
			countries.RemoveAt(0);
		}
	}
}
