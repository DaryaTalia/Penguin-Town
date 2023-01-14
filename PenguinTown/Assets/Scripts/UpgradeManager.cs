using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UpgradeManager : MonoBehaviour
{
    GameObject gm;
    [SerializeField]
    public GameObject upgrade;

    [SerializeField] 
    public TMP_Text costTXT;
    [SerializeField] 
    public TMP_Text damageRewardTXT;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("PrimarySystemManager");
        costTXT.text = "Cost to Upgrade: {START()}";
        damageRewardTXT.text = "Damage Reward: {START()}";
    }

    // Update is called once per frame
    void Update()
    {
        costTXT.text = "Cost: $" + upgrade.GetComponent<ClickDamageUpgrade>().GetCost();
        damageRewardTXT.text = "Damage Reward: +" + upgrade.GetComponent<ClickDamageUpgrade>().GetDamageReward();
    }
}
