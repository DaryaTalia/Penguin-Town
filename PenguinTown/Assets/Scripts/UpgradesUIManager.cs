using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UpgradesUIManager : MonoBehaviour
{
    GameObject gm;

    [SerializeField] 
    public TMP_Text fundsTXT;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("PrimarySystemManager");
        fundsTXT.text = "Funds: {START()}";
    }

    // Update is called once per frame
    void Update()
    {
        fundsTXT.text = "Funds: " + gm.GetComponent<GameSystem>().GetFunds();
    }
}
