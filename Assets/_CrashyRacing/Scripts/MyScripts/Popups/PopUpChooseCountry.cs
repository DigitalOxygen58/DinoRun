using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpChooseCountry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnEnable()
	{
        //GetComponentInChildren<Country>().countryChoosed += exitPopupChooseCountry;
	}

    private void exitPopupChooseCountry()
    {
        gameObject.SetActive(false);
    }
}
