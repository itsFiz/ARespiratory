using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class setActiveLungs : MonoBehaviour
{
    public GameObject SuperiorLobe;
    public GameObject MiddleLobe;
    public GameObject InferiorLobe;
    public GameObject RightBronchus;
    public GameObject Trachea;
    public GameObject LeftBronchus;
    public GameObject SuperiorRight;
    public GameObject MiddleRight;
    public GameObject InferiorRight;
    public GameObject fissure;

    public GameObject HideButton;
    public GameObject showButton;

    void Start()
    {
        
    }


    public void hide()
    {
        HideButton.SetActive(false);
        showButton.SetActive(true);
        SuperiorLobe.SetActive(false);
        MiddleLobe.SetActive(false);
        InferiorLobe.SetActive(false);
        RightBronchus.SetActive(false);
        Trachea.SetActive(false);
        LeftBronchus.SetActive(false);
        SuperiorRight.SetActive(false);
        MiddleRight.SetActive(false);
        InferiorRight.SetActive(false);
        fissure.SetActive(false);

    }

    public void show()
    {
        HideButton.SetActive(true);
        showButton.SetActive(false);
        SuperiorLobe.SetActive(true);
        MiddleLobe.SetActive(true);
        InferiorLobe.SetActive(true);
        RightBronchus.SetActive(true);
        Trachea.SetActive(true);
        LeftBronchus.SetActive(true);
        SuperiorRight.SetActive(true);
        MiddleRight.SetActive(true);
        InferiorRight.SetActive(true);
        fissure.SetActive(true);

    }

}
