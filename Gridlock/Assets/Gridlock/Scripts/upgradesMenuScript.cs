using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class upgradesMenuScript : MonoBehaviour
{
    private TMP_Text _textMesh;

    [SerializeField] public GameObject[] skins;
    [SerializeField] public GameObject[] upgrades;

    private bool[] skinSet;
    private bool[] upgradeSet;

    private int length = 0;
    void Start()
    {
        _textMesh = GameObject.Find("livescount").GetComponent<TMP_Text>();
        _textMesh.text = "x"+uiManagerScript.livesCount.ToString();

        length = skins.Length;
        Debug.Log(length);
    }
}
