using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storePageScript : MonoBehaviour
{
    public GameObject bundles;
    public GameObject skins;
    public GameObject upgrades;

    private void OnEnable()
    {
        bundles.SetActive(true);
        skins.SetActive(false);
        upgrades.SetActive(false);
    }
    public void bundles_pressed()
    {
        bundles.SetActive(true);
        skins.SetActive(false);
        upgrades.SetActive(false);
    }
    public void skins_pressed()
    {
        bundles.SetActive(false);
        skins.SetActive(true);
        upgrades.SetActive(false);
    }
    public void upgrades_pressed()
    {
        bundles.SetActive(false);
        skins.SetActive(false);
        upgrades.SetActive(true);
    }
}
