using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class RateApplication : MonoBehaviour
{
    [SerializeField]
    private Button[] starsButtons = new Button[5];

    public Action onClick;
    void Start()
    {
		for (int i = 0; i < starsButtons.Length; i++)
		{
            int a = i;
            starsButtons[a].onClick.AddListener(() =>
            {
                onClick?.Invoke();
                Debug.Log(onClick);
                Debug.Log("Hi = " + a);
                for (int j = 0; j <= a; j++)
				{
                    starsButtons[j].GetComponent<Image>().color=Color.yellow;
                }
                for (int l = a+1; l < starsButtons.Length; l++)
                {
                    starsButtons[l].GetComponent<Image>().color = Color.white;
                }

            });
        }
    }

}
