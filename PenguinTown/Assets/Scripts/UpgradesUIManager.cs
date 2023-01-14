using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UpgradesUIManager : MonoBehaviour
{
    private GameObject gm;

    [SerializeField] 
    public GameObject upgrade;

    //Individual Upgrade Data
    [SerializeField] 
    public TMP_Text costTXT;
    [SerializeField] 
    public TMP_Text damageRewardTXT;

    //Menu Bar
    [SerializeField] 
    public TMP_Text fundsTXT;
    [SerializeField] 
    public TMP_Text clickDamageTXT;
    [SerializeField] 
    public TMP_Text dpsTXT;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("PrimarySystemManager");
        fundsTXT.text = "Funds: {START()}";
        costTXT.text = "Cost to Upgrade: {START()}";
        damageRewardTXT.text = "Damage Reward: {START()}";
        clickDamageTXT.text = "Click Damage: {START()}";
        dpsTXT.text = "DPS: {START()}";
    }

    // Update is called once per frame
    void Update()
    {
        fundsTXT.text = "Funds: " + gm.GetComponent<GameSystem>().GetFunds();
        costTXT.text = "Cost: $" + upgrade.GetComponent<ClickDamageUpgrade>().GetCost();
        damageRewardTXT.text = "Damage Reward: +" + upgrade.GetComponent<ClickDamageUpgrade>().GetDamageReward();
        clickDamageTXT.text = "Click Damage: " + gm.GetComponent<GameSystem>().GetClickDamage();
        dpsTXT.text = "DPS: +" + gm.GetComponent<GameSystem>().GetDPS();
    }
}
