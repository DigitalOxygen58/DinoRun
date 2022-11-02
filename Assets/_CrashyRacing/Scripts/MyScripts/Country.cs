using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Events;
using TMPro;

public class Country : MonoBehaviour
{
	public Action countryChoosed;
	public UnityEvent<Country> OnCountrySelected;
	public CountryData countryData;

	[SerializeField]
	private Image image;
	[SerializeField]
	private TMP_Text countryNameText;
	[SerializeField]
	private Button button;


	private void Awake()
	{
		button.onClick.AddListener(() => OnCountrySelected?.Invoke(this));
	}

	void Start()
	{
		transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() => { countryChoosed?.Invoke(); });
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void Initialize(CountryData countryData)
	{
		this.countryData = countryData;
		image = countryData.countryFlag;
		countryNameText.text = countryData.countryName;
	}
}

[System.Serializable]
public class CountryData
{
	public string countryName;
	public Image countryFlag;
	public string countryShopURL;
}
