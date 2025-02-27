using UnityEngine;
using UnityEditor;
using System;
using System.Linq;
using Unity.VisualScripting;
using JetBrains.Annotations;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

public class SceneChanger : MonoBehaviour
{


    public GameObject MainMenu;
    public GameObject WizMeeting;
    public GameObject WizDeclined;
    public GameObject WizAccepted;
    public GameObject GardenInitial;
    public GameObject GardenStage2;
    public GameObject GardenDeath;
    public GameObject GardenTeeter;
    public GameObject GardenVictory;
    public GameObject ForestInitial;
    public GameObject ForestCrossroads;
    public GameObject VillageRenewed;
    int gardenWeight = 0;
    int forestWeight = 0;
    int neutralWeight = 0;
    public bool potionTaken = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void transparentScenes()
    {
        //wizard is met
        if(neutralWeight == 0)
        {
            MainMenu.SetActive(false);
            WizMeeting.SetActive(true);
            neutralWeight = 1;
            return;
        }
        


        //player goes to garden
        if(gardenWeight == 1)
        {
            WizDeclined.SetActive(false);
            WizAccepted.SetActive(false);
            GardenInitial.SetActive(true);
            gardenWeight++;
            return;
        }
        //player goes to garden
        if(gardenWeight == 2)
        {
            GardenInitial.SetActive(false);
            GardenStage2.SetActive(true);
            gardenWeight++;
            return;
        }

        if(gardenWeight == 3 && potionTaken == true)
        {
            GardenStage2.SetActive(false);
            GardenTeeter.SetActive(true);
            gardenWeight++;
            return;
        }
        else if(gardenWeight == 3)
        {
            GardenStage2.SetActive(false);
            GardenDeath.SetActive(true);
            return;
        }

        if(gardenWeight == 4)
        {
            GardenTeeter.SetActive(false);
            GardenVictory.SetActive(true);
            return;
        }



        //player goes to forest
        if(forestWeight == 1)
        {
            WizDeclined.SetActive(false);
            WizAccepted.SetActive(false);
            ForestInitial.SetActive(true);
            forestWeight++;
            return;
        }

        if(forestWeight == 2)
        {
            ForestInitial.SetActive(false);
            ForestCrossroads.SetActive(true);
            forestWeight++;
            return;
        }

        if(forestWeight == 3)
        {
            ForestCrossroads.SetActive(false);
            VillageRenewed.SetActive(true);
            return;
        }

                //wiz gets paid
        if(neutralWeight == 1 && potionTaken == true)
        {
            WizMeeting.SetActive(false);
            WizAccepted.SetActive(true);
            return;
        }

        

        //wiz gets sad
        else if(neutralWeight == 1)
        {
            WizMeeting.SetActive(false);
            WizDeclined.SetActive(true);
            return;
        }




    }
    public void wizAccept()
    {
        potionTaken = true;
    }
    public void forestPath()
    {
        forestWeight=1;
        return;
    }
    public void gardenPath()
    {
        gardenWeight=1;
        return;
    }
}
