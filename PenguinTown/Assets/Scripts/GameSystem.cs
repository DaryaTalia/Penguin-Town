using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameSystem : MonoBehaviour
{
    double clickDamage;
    double cdRate; //Click Damage Rate
    double cdRateModifier; // Click Damage Rate Modifier

    double dps;
    double dpsRate; //DPS Rate
    double dpsRateModifier; // DPS Rate Modifier

    double funds;

    [SerializeField] public GameObject IceSculptureSpawnPoint;
    [SerializeField] public GameObject IceSculpturePrefab;
    GameObject iceSculpture;

    double maxHealth;
    double healthRate;
    double maxReward;
    double rewardRate;

    double maxID = 0;
    double penguinCount = 0;

    //Statistics
    double highestEverID;
    double highestEverPenguins;
    //double highestEverClickDamage;
    //double highestEverDPS;
    //double moneyEarnedLifetime;

    // Start is called before the first frame update
    void Start()
    {
        //Initialize Variables
        maxID = 1;
        funds = 0;
        penguinCount = 0;

        highestEverID = 0;
        highestEverPenguins = 0;

        clickDamage = 1.0;
        cdRate = .25;
        cdRateModifier = 1;

        dps = 0;
        dpsRate = .25;
        dpsRateModifier = 1;

        maxHealth = 10.0;
        healthRate = .05;
        maxReward = 2.0;
        rewardRate = .05;

        iceSculpture = Instantiate(IceSculpturePrefab, IceSculptureSpawnPoint.transform.position, Quaternion.identity);
        iceSculpture.GetComponent<IceSculptureController>().Initialize(maxHealth, maxReward, maxID);
    }

    // Update is called once per frame
    void Update()
    {
        if(iceSculpture == null) {
            SpawnNewIceSculpture();
        }
        
        /*if(clickDamage > highestEverClickDamage) {
            highestEverClickDamage = clickDamage;
        }

        if(dps > highestEverDPS) {
            highestEverDPS = dps;
        }*/

        if(maxID > highestEverID) {
            highestEverID = maxID;
        }

        if(penguinCount > highestEverPenguins) {
            highestEverPenguins = penguinCount;
        }

        


    }

    public double GetDPS() {
        return dps;
    }

    public double GetClickDamage() {
        return clickDamage;
    }

    public double GetMaxID() {
        return maxID;
    }

    public double GetFunds() {
        return funds;
    }

    public void UpdateFunds(double val) {
        funds += val;
    }

    public void UpdateDPS(double val) {
        dps += val;
    }

    public void UpdateClickDamage(double val) {
        clickDamage += val;
    }

    public double GetIceSculptureHealth() {
        return iceSculpture.GetComponent<IceSculptureController>().GetHealth();
    }

    public void SpawnNewIceSculpture() {

        maxHealth += maxHealth * healthRate;
        maxReward += maxReward * rewardRate;

        maxHealth = Math.Round(maxHealth, 2);
        maxReward = Math.Round(maxReward, 2);
        maxID++;

        iceSculpture = Instantiate(IceSculpturePrefab, IceSculptureSpawnPoint.transform.position, Quaternion.identity);
        iceSculpture.GetComponent<IceSculptureController>().Initialize(maxHealth, maxReward, maxID);
    }

}
