using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class uiManagerScript : MonoBehaviour
{
    public int NoOfLives = 15;
    [SerializeField] public static int livesCount;

    [SerializeField] 
    public GameObject MainsMenu;
    public GameObject LevelsMenu;

    public int[] NumberOfLevels;
    private Image mask;
    [SerializeField] public GameObject LevelPrefab;

    public GameObject PrefabHolder;
    
    private void Start()
    {
        livesCount = NoOfLives;
        MainsMenu.SetActive(true);
        //change mask area for levels
        if(LevelsMenu.activeSelf)
        {
            LevelsMenuFunction();
        }
        
    }

    private void Update()
    {
        if (!LevelsMenu.activeSelf)
        {
            foreach (Transform child in PrefabHolder.transform) {
                GameObject.Destroy(child.gameObject);
            }
        }
    }


    public void LevelsMenuFunction()
    {
        mask = GameObject.Find("content").GetComponent<Image>();
        mask.rectTransform.sizeDelta = new Vector2(mask.rectTransform.sizeDelta.x,
            ((NumberOfLevels.Length * 90) + NumberOfLevels.Length));

        for (var i = 0; i < NumberOfLevels.Length; i++)
        {
            GameObject fab = Instantiate(LevelPrefab, GameObject.Find("content").transform, true) as GameObject;
            fab.transform.localScale = new Vector3(1f,1f,1f);
            TMP_Text _text = fab.GetComponentInChildren<TMP_Text>();
            _text.text = "LEVEL " + (NumberOfLevels.Length - i);

            GameObject stars = fab.transform.Find("stars").gameObject;

            GameObject zero = stars.transform.Find("zero").gameObject;
            GameObject one = stars.transform.Find("one").gameObject;
            GameObject two = stars.transform.Find("two").gameObject;
            GameObject three = stars.transform.Find("three").gameObject;


            switch (NumberOfLevels[NumberOfLevels.Length - (i + 1)])
            {
                case 0:
                    zero.SetActive(true);
                    break;
                case 1:
                    one.SetActive(true);
                    break;
                case 2:
                    two.SetActive(true);
                    break;
                default:
                    three.SetActive(true);
                    break;
            }
        }
    }
    
}
