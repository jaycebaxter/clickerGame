// Program: OSRS Clicker
// Author: Jayce Baxter-Johnson
// Date: December 7th, 2025
// Description: Allows the user to play a cookie clicker style game
//              based on Oldschool Runescape, with 3 skills to train:
//              Mining, Woodcutting, and Agility.

using UnityEngine;

public class Woodcutting : MonoBehaviour
{
    public GameEvents gameEvents;

    public GameObject agilityButton;
    public GameObject woodcuttingButton;
    public GameObject miningButton;

    public GameObject GEImage;
    public GameObject miningImage;
    public GameObject rooftopImage;
    public GameObject woodcuttingImage;

    public GameObject treeButton;
    public GameObject oakButton;
    public GameObject willowButton;
    public GameObject TeakButton;
    public GameObject mapleButton;
    public GameObject mahoganyButton;
    public GameObject yewButton;
    public GameObject magicButton;
    public GameObject redwoodButton;

    public Mining mining;
    public Agility agility;

    // Reset / default state
    public void Start() {
        HideTrees();
        mining.HideOres();
        agility.HideRooftops();
    }

    // Shows woodcutting UI and hides UI from other skills
    public void ShowTrees() {
        treeButton.SetActive(true);

        GEImage.SetActive(false);
        woodcuttingImage.SetActive(true);
        miningImage.SetActive(false);
        rooftopImage.SetActive(false);
        
        UnlockTrees();
        mining.HideOres();
        agility.HideRooftops();
    }

    // Hides all trees, used for mining and agility
    public void HideTrees() {
        treeButton.SetActive(false);
        oakButton.SetActive(false);
        willowButton.SetActive(false);
        TeakButton.SetActive(false);
        mapleButton.SetActive(false);
        mahoganyButton.SetActive(false);
        yewButton.SetActive(false);
        magicButton.SetActive(false);
        redwoodButton.SetActive(false);
    }

    // Unlocks trees based on woodcutting level
    public void UnlockTrees() {
        if (gameEvents.GetWoodcuttingLevel() >=15) {
            oakButton.SetActive(true);
        }

        if (gameEvents.GetWoodcuttingLevel() >=30) {
            willowButton.SetActive(true);
        }

        if (gameEvents.GetWoodcuttingLevel() >=35) {
            TeakButton.SetActive(true);
        }

        if (gameEvents.GetWoodcuttingLevel() >=45) {
            mapleButton.SetActive(true);
        }

        if (gameEvents.GetWoodcuttingLevel() >=50) {
            mahoganyButton.SetActive(true);
        }

        if (gameEvents.GetWoodcuttingLevel() >=60) {
            yewButton.SetActive(true);
        }

        if (gameEvents.GetWoodcuttingLevel() >=75) {
            magicButton.SetActive(true);
        }

        if (gameEvents.GetWoodcuttingLevel() >=90) {
            redwoodButton.SetActive(true);
        }
    }

    // Adds xp based on tree chopped
    public void treeClicked()
    {
        gameEvents.AddWoodcuttingXP(25f);
    }

    public void oakClicked()
    {
        gameEvents.AddWoodcuttingXP(37.5f);
    }

    public void willowClicked()
    {
        gameEvents.AddWoodcuttingXP(67.5f);
    }

    public void teakClicked()
    {
        gameEvents.AddWoodcuttingXP(85f);
    }

    public void mapleClicked()
    {
        gameEvents.AddWoodcuttingXP(100f);
    }

    public void mahoganyClicked()
    {
        gameEvents.AddWoodcuttingXP(125f);
    }

    public void yewClicked()
    {
        gameEvents.AddWoodcuttingXP(175f);
    }

    public void magicClicked()
    {
        gameEvents.AddWoodcuttingXP(250f);
    }

    public void redwoodClicked()
    {
        gameEvents.AddWoodcuttingXP(380f);
    }
    
}