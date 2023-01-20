using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDamageUpgrade : MonoBehaviour
{
    GameObject gm;

    double cost;
    double costRate;
    double damage;
    double damageRate;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("PrimarySystemManager");

        cost = 15;
        costRate = .3;
        damage = 1;
        damageRate = .2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Essentially BuyUpgrade()
    private void OnMouseDown() {
        if(gm.GetComponent<GameSystem>().GetFunds() >= cost) {
            gm.GetComponent<GameSystem>().UpdateClickDamage(damage);
            gm.GetComponent<GameSystem>().UpdateFunds(-cost);

            cost += cost * costRate;
            damage += damage * damageRate;
        }
    }

    public double GetCost() {
        return cost;
    }

    public double GetDamage() {
        return damage;
    }

    public double GetDamageReward() {
        return damage + (damage * damageRate);
    }

}
