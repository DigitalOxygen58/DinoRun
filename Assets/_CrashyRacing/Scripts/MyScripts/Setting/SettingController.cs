using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class SettingController : MonoBehaviour
{
    public Button activationRateUs;
    public Button activationHelpAndSupport;
	public Button deactivationHelpAndSupport;

	public GameObject popUpRateUs;
    public GameObject popUpHelpAndSupport;

    void Start()
    {
        activationRateUs.onClick.AddListener(() => { popUpRateUs.SetActive(true);  });
        activationHelpAndSupport.onClick.AddListener(() => { popUpHelpAndSupport.SetActive(true); });

		deactivationHelpAndSupport.onClick.AddListener(() => { popUpHelpAndSupport.SetActive(false); });
	}
}
