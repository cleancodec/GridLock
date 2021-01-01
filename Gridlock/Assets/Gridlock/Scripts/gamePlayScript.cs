using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gamePlayScript : MonoBehaviour
{
    private TMP_Text _textMesh;
    void Start()
    {
        _textMesh = GameObject.Find("livescount").GetComponent<TMP_Text>();
        _textMesh.text = "x"+uiManagerScript.livesCount.ToString();
    }
}
