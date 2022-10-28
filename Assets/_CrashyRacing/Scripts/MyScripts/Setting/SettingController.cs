using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class SettingController : MonoBehaviour
{
    public Button activationRateUs;
    public Button deactivationonRateUs;

    public Button activationHelpAndSupport;
    public Button deactivationHelpAndSupport;


    public GameObject popUpRateUs;
    public GameObject popUpHelpAndSupport;

    public RateApplication rate;

    void Start()
    {
        activationRateUs.onClick.AddListener(() => { popUpRateUs.SetActive(true); deactivationonRateUs.interactable = false; });
        deactivationonRateUs.onClick.AddListener(() => { popUpRateUs.SetActive(false); });

        activationHelpAndSupport.onClick.AddListener(() => { popUpHelpAndSupport.SetActive(true); });
        deactivationHelpAndSupport.onClick.AddListener(() => { popUpHelpAndSupport.SetActive(false); });

    }
	private void OnEnable()
	{
        rate.onClick += NewMethod;
	}

	private void NewMethod()
	{
        Debug.Log("POPOPO");
		 deactivationonRateUs.interactable = true; 
	}

	void Update()
    {
        
    }
}
