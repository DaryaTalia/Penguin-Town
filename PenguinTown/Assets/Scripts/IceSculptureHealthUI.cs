using UnityEngine;
using UnityEngine.UI;

public class IceSculptureHealthUI : MonoBehaviour
{
    [SerializeField]
    public Image healthMeter;

    public void UpdateHealthMeter(double maxHealth, double currHealth)
    {
        var result = currHealth / maxHealth;
        healthMeter.fillAmount = (float) result;
    }
}
