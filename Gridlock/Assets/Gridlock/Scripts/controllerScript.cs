using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class controllerScript : MonoBehaviour
{
    [SerializeField] public LeanTweenType Type;
    [SerializeField] public GameObject from;
    [SerializeField] public GameObject to;
    [SerializeField] public bool ScreeTransition = false;
    
    [SerializeField] public LeanTweenType screeTransitionType;

    

    
    public uiManagerScript _uiManagerScript;

    public void buttonPressed()
    {
        LeanTween.scale(gameObject, new Vector3(1.2f, 1.2f, 1f), 0.05f).setEase(Type);
            LeanTween.scale(gameObject, new Vector3(1f, 1f, 1f), 0.05f).setEase(Type).setDelay(0.05f);
            LeanTween.delayedCall(gameObject, 0.1f, ()=>
            {
                if (ScreeTransition)
                {
                    Screen_transition();
                }
                else
                {
                    transition();
                }
                if (to.name == "Levels Menu")
                {
                    _uiManagerScript.LevelsMenuFunction();
                }
            });
        
        
    }

    

    public void settings()
    {
        LeanTween.scale(gameObject, new Vector3(1.2f, 1.2f, 1f), 0.05f).setEase(Type);
        LeanTween.rotateLocal(gameObject, new Vector3(1f, 1f,180f), 0.5f).setDelay(0.05f);
        LeanTween.scale(gameObject, new Vector3(1f, 1f, 1f), 0.05f).setEase(Type).setDelay(0.55f);  
        LeanTween.delayedCall(gameObject, 0.6f, ()=>
        {
            transform.eulerAngles = new Vector3(0f,0f,0f);
            transition();
        });
    }

    public void transition()
    {
        from.SetActive(false);
        to.SetActive(true);
    }
    public void Screen_transition()
    {
        LeanTween.scale(@from, new Vector3(1.1f, 1.1f, 1.1f), 0.05f).setEase(screeTransitionType);
        LeanTween.scale(@from, new Vector3(1f, 1f, 1f), 0.05f).setEase(screeTransitionType).setDelay(0.05f);
        to.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
        LeanTween.delayedCall(gameObject, 0.1f, ()=>
        {
            
            to.SetActive(true);
            from.SetActive(false);
            LeanTween.scale(@to, new Vector3(1f, 1f, 1f), 0.05f).setEase(screeTransitionType);
           
        });
    }
   
    
}
