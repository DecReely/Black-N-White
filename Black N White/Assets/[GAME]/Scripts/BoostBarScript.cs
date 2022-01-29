using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostBarScript : MonoBehaviour
{
    public Image BoostBar;
    public float currentBoost;
    public float maxBoost;
    public PlayerStats playerStats;

    private void Start()
    {
        maxBoost = PlayerStats.MaxBoostAmount;
    }

    void Update()
    {
        currentBoost = playerStats.boostAmount;
        BoostBar.fillAmount = currentBoost / maxBoost;
    }
}
