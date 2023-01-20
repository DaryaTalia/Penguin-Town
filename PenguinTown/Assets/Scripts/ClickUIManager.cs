using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ClickUIManager : MonoBehaviour
{
    GameObject gm;

    [SerializeField] 
    public TMP_Text levelTXT;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("PrimarySystemManager");
        levelTXT.text = "Level: {START()}";
    }

    // Update is called once per frame
    void Update()
    {
        levelTXT.text = "Level: " + gm.GetComponent<GameSystem>().GetMaxID();
    }
}
