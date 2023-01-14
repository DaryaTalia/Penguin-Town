using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IceSculptureController : MonoBehaviour
{
    GameObject gm;

    private double health;
    private double reward;
    private double ID;

    void Start() {
        gm = GameObject.Find("PrimarySystemManager");
    }

    /* Update() will monitor damage taken from the damage per second variable in the game manager. */
    void Update()
    {
        health = Math.Round(health, 2)
;
        //health -= GameManager.DPS;
        if(health <= 0) {
            gm.GetComponent<GameSystem>().UpdateFunds(reward);
            Destroy(gameObject);
        } else {
            health -= gm.GetComponent<GameSystem>().GetDPS();
        }
    }

    public double GetHealth() {
        return health;
    }

    public double GetReward() {
        return reward;
    }

    public void Initialize(double hlt, double rwd, double newID) {
        health = hlt;
        reward = rwd;
        ID = newID;
    }

    /* If this Ice Sculpture is clicked on, it will run this action once */
    private void OnMouseDown() {
        if(health > 0) {
            health -= gm.GetComponent<GameSystem>().GetClickDamage();
        }
    }

}
