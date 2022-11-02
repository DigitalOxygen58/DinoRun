using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PopupRateUs : MonoBehaviour
{
	[SerializeField]
	private Button exitButton;
	[SerializeField]
	private Button cansleButton;

	public Action exitPopupRateUs;

	void Start()
	{
		exitButton.onClick.AddListener(() =>
		{
			exitPopupRateUs?.Invoke();
			gameObject.SetActive(false);
		});

		cansleButton.onClick.AddListener(() => { gameObject.SetActive(false); });
	}
	private void OnEnable()
	{
		exitButton.interactable = false;

		GetComponentInChildren<RatingApplication>().onClickStar += InteractableExitButton;
	}

	private void InteractableExitButton()
	{
		exitButton.interactable = true;
	}
}
