using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseCountry : MonoBehaviour
{
    [SerializeField]
    private Button openPopupCountrysButton;
    [SerializeField]
    private Button exitButton;
    [SerializeField]
    private GameObject popupChooseCountry;

    public bool counytrySelected;


    void Start()
    {
        exitButton.interactable = counytrySelected ? true : false;
        openPopupCountrysButton.onClick.AddListener(() => { popupChooseCountry.SetActive(true); });
    }

}
