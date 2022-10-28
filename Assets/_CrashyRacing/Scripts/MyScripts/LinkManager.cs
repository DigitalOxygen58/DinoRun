using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LinkManager : MonoBehaviour
{
    public GameObject policy;
    public GameObject TermOfUse;

    void Start()
    {
        policy.GetComponent<Button>().onClick.AddListener(()=> { Application.OpenURL("https://www.google.ru/"); });
        TermOfUse.GetComponent<Button>().onClick.AddListener(() => { Application.OpenURL("https://www.google.ru/"); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
