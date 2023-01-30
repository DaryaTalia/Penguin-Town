using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DPSButton : MonoBehaviour
{
    GameObject gm;

    double cost;
    double costRate;
    double dps;
    double dpsRate;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("PrimarySystemManager");
    }

    private void OnMouseDown() {
        if(cost <= gm.GetComponent<GameSystem>().GetFunds()) {
            BuyUpgrade();
        }
    }

    void BuyUpgrade() {
        gm.GetComponent<GameSystem>().UpdateFunds(-cost);
        cost += cost * costRate;
        gm.GetComponent<GameSystem>().UpdateDPS(dps);
        dps += dps * dpsRate;
    }
}
