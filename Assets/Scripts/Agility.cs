// Program: OSRS Clicker
// Author: Jayce Baxter-Johnson
// Date: December 7th, 2025
// Description: Allows the user to play a cookie clicker style game
//              based on Oldschool Runescape, with 3 skills to train:
//              Mining, Woodcutting, and Agility.

using UnityEngine;

public class Agility : MonoBehaviour
{
    public GameEvents gameEvents;

    public GameObject agilityButton;
    public GameObject woodcuttingButton;
    public GameObject miningButton;

    public GameObject GEImage;
    public GameObject miningImage;
    public GameObject rooftopImage;
    public GameObject woodcuttingImage;

    public GameObject draynorButton;
    public GameObject alKharidButton;
    public GameObject varrockButton;
    public GameObject canifisButton;
    public GameObject faladorButton;
    public GameObject seersButton;
    public GameObject pollnivButton;
    public GameObject rellekkaButton;
    public GameObject ardougneButton;

    public Mining mining;
    public Woodcutting woodcutting;

    // Reset / default state
    public void Start() {
        HideRooftops();
        mining.HideOres();
        woodcutting.HideTrees();
    }

    // Shows agility UI and hides UI from other skills
    public void ShowRooftops() {
        GEImage.SetActive(false);
        miningImage.SetActive(false);
        woodcuttingImage.SetActive(false);
        rooftopImage.SetActive(true);
        draynorButton.SetActive(true);
        mining.HideOres();
        woodcutting.HideTrees();
        UnlockRooftops();
    }

    // Hides all rooftops, used for woodcutting and mining
    public void HideRooftops() {
        draynorButton.SetActive(false);
        alKharidButton.SetActive(false);
        varrockButton.SetActive(false);
        canifisButton.SetActive(false);
        faladorButton.SetActive(false);
        seersButton.SetActive(false);
        pollnivButton.SetActive(false);
        rellekkaButton.SetActive(false);
        ardougneButton.SetActive(false);
    }

    // Unlocks rooftops based on agility level
    public void UnlockRooftops() {
        if (gameEvents.GetAgilityLevel() >=20) {
            alKharidButton.SetActive(true);
        }

        if (gameEvents.GetAgilityLevel() >=30) {
            varrockButton.SetActive(true);
        }
        
        if (gameEvents.GetAgilityLevel() >=40) {
            canifisButton.SetActive(true);
        }

        if (gameEvents.GetAgilityLevel() >=50) {
            faladorButton.SetActive(true);
        }

        if (gameEvents.GetAgilityLevel() >=60) {
            seersButton.SetActive(true);
        }

        if (gameEvents.GetAgilityLevel() >=70) {
            pollnivButton.SetActive(true);
        }

        if (gameEvents.GetAgilityLevel() >=80) {
            rellekkaButton.SetActive(true);
        }

        if (gameEvents.GetAgilityLevel() >=90) {
            ardougneButton.SetActive(true);
        }
    }

    // Adds xp based on rooftop lap run
    public void draynorClicked()
    {
        gameEvents.AddAgilityXP(120f);
    }

    public void alKharidClicked()
    {
        gameEvents.AddAgilityXP(216f);
    }

    public void varrockClicked()
    {
        gameEvents.AddAgilityXP(240f);
    }

    public void canifisClicked()
    {
        gameEvents.AddAgilityXP(270f);
    }

    public void faladorClicked()
    {
        gameEvents.AddAgilityXP(570f);
    }

    public void seersClicked()
    {
        gameEvents.AddAgilityXP(586f);
    }

    public void pollnivClicked()
    {
        gameEvents.AddAgilityXP(890f);
    }

    public void rellekkaClicked()
    {
        gameEvents.AddAgilityXP(920f);
    }

    public void ardougneClicked()
    {
        gameEvents.AddAgilityXP(960f);
    }
    
}