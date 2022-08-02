using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    public Image healthBar;

    private void Awake()
    {
        healthBar = GetComponentInChildren<Image>();

        GameEvents.OnPlayerHealth.AddListener(ChangeHealthBar);

        GameEvents.OnDamagePlayer.AddListener(HealthBarRatio);
        GameEvents.OnDamagePlayer.AddListener((float ratio) =>
        {
            healthBar.fillAmount = ratio;
        });


    }

    private void HealthBarRatio (float ratio)
    {

    }

    private void ChangeHealthBar (int health)
    {
        Debug.Log($"ChangeHealthBar {health}");
    }


}
