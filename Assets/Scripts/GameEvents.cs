// Program: OSRS Clicker
// Author: Jayce Baxter-Johnson
// Date: December 7th, 2025
// Description: Allows the user to play a cookie clicker style game
//              based on Oldschool Runescape, with 3 skills to train:
//              Mining, Woodcutting, and Agility.

using UnityEngine;
using UnityEngine.UI;

public class GameEvents : MonoBehaviour
{
    public GameObject selectSkillButton;
    public GameObject miningButton;
    public GameObject woodcuttingButton;
    public GameObject agilityButton;

    public GameObject levelUpButton;
    public Text levelUpText;
    public GameObject miningLevelImage;
    public GameObject agilityLevelImage;
    public GameObject woodcuttingLevelImage;

    public Text miningLevelLabel;
    public Text miningXPLabel;
    public Text agilityLevelLabel;
    public Text agilityXPLabel;
    public Text woodcuttingLevelLabel;
    public Text woodcuttingXPLabel;

    private float miningXP = 0f;
    private float agilityXP = 0f;
    private float woodcuttingXP = 0f;

    private int miningLevel = 1;
    private int agilityLevel = 1;
    private int woodcuttingLevel = 1;

    private static float baseMiningXP = 83f;
    private static float baseAgilityXP = 83f;
    private static float baseWoodcuttingXP = 83f;
    private float nextMiningXP = baseMiningXP;
    private float nextAgilityXP = baseAgilityXP;
    private float nextWoodcuttingXP = baseWoodcuttingXP;
    private float growth = 1.1040895f;
    private int lastWoodcuttingLvl= 0;
    private int lastMiningLvl = 0;
    private int lastAgilityLvl = 0;

    public Mining mining;
    public Agility agility;
    public Woodcutting woodcutting;

    // Used for when the game first starts and only the select skills button is available
    void Start()
    {
        UpdateMiningXPLabel();
        UpdateMiningLevel();
        UpdateAgilityXPLabel();
        UpdateAgilityLevel();
        UpdateWoodcuttingXPLabel();
        UpdateWoodcuttingLevel();
        miningButton.SetActive(false);
        woodcuttingButton.SetActive(false);
        agilityButton.SetActive(false);
    }

    // Select skill button clicked 
    public void SelectSkillClicked()
    {
        selectSkillButton.SetActive(false);
        miningButton.SetActive(true);
        woodcuttingButton.SetActive(true);
        agilityButton.SetActive(true);
    }

    // Adds xp based on ore mined
    public void AddMiningXP(float amount)
    {
        miningXP += amount;
        UpdateMiningXPLabel();
        UpdateMiningLevel();
        mining.UnlockOres();
    }

    // Adds xp based on rooftop lap run
    public void AddAgilityXP(float amount)
    {
        agilityXP += amount;
        UpdateAgilityXPLabel();
        UpdateAgilityLevel();
        agility.UnlockRooftops();
    }

    // Adds xp based on tree chopped
    public void AddWoodcuttingXP(float amount)
    {
        woodcuttingXP += amount;
        UpdateWoodcuttingLevel();
        UpdateWoodcuttingXPLabel();
        woodcutting.UnlockTrees();
    }

    // Updates mining xp label
    public void UpdateMiningXPLabel()
    {
        miningXPLabel.text = "Mining XP: " + miningXP;
    }

    // Updates agility xp label
    public void UpdateAgilityXPLabel()
    {
        agilityXPLabel.text = "Agility XP: " + agilityXP;
    }
    
    // Updates woodcutting xp label
    public void UpdateWoodcuttingXPLabel()
    {
        woodcuttingXPLabel.text = "Woodcutting XP: " + woodcuttingXP;
    }

    // Updates mining level and label
    public void UpdateMiningLevel() {
        float nextMiningXP = baseMiningXP;
        int newMiningLevel = 1;

        // 99 is the max level in runescape so we stop at 99
        while (miningXP >= nextMiningXP && newMiningLevel < 99) {
            newMiningLevel++;

            // The formula in runescape is based on exponential growth
            nextMiningXP += baseMiningXP * Mathf.Pow(growth, newMiningLevel - 2);
        }
        
        miningLevel = newMiningLevel;

        // Sets mining level label
        miningLevelLabel.text = "Mining Level: " + miningLevel;

        // Gives a level up notification every 10 levels, and at max level
        if ((miningLevel % 10 == 0 || miningLevel == 99) && miningLevel != lastMiningLvl) {
            levelUpButton.SetActive(true);
            miningLevelImage.SetActive(true);
            levelUpText.text = "Congratulations, you just advanced a Mining level. \n" + 
            "Your Mining level is now " + miningLevel + ". \n" +
            "Click here to continue.";
            lastMiningLvl = miningLevel;
        }
    }

    // Get mining level
    public int GetMiningLevel() {
        return miningLevel;
    }

    // Updates agility level and label
    public void UpdateAgilityLevel() {
        float nextAgilityXP = baseAgilityXP;
        int newAgilityLevel = 1;

        // 99 is the max level in runescape so we stop at 99
        while (agilityXP >= nextAgilityXP && newAgilityLevel < 99) {
            newAgilityLevel++;

            // The formula in runescape is based on exponential growth
            nextAgilityXP += baseAgilityXP * Mathf.Pow(growth, newAgilityLevel - 2);
        }
        
        agilityLevel = newAgilityLevel;

        // Sets agility level label
        agilityLevelLabel.text = "Agility Level: " + agilityLevel;

        // Gives a level up notification every 10 levels, and at max level
        if ((agilityLevel % 10 == 0 || agilityLevel == 99) && agilityLevel != lastAgilityLvl) {
            levelUpButton.SetActive(true);
            agilityLevelImage.SetActive(true);
            levelUpText.text = "Congratulations, you just advanced an Agility level. \n" + 
            "Your Agility level is now " + agilityLevel + ". \n" +
            "Click here to continue.";
            lastAgilityLvl = agilityLevel;
        }
    }

    // Get agility level
    public int GetAgilityLevel() {
        return agilityLevel;
    }

    // Updates woodcutting level and label
    public void UpdateWoodcuttingLevel() {
        float nextWoodcuttingXP = baseWoodcuttingXP;
        int newWoodcuttingLevel = 1;

        // 99 is the max level in runescape so we stop at 99
        while (woodcuttingXP >= nextWoodcuttingXP && newWoodcuttingLevel < 99) {
            newWoodcuttingLevel++;

            // The formula in runescape is based on exponential growth
            nextWoodcuttingXP += baseWoodcuttingXP * Mathf.Pow(growth, newWoodcuttingLevel - 2);
        }
        
        woodcuttingLevel = newWoodcuttingLevel;

        // Sets woodcutting level label
        woodcuttingLevelLabel.text = "Woodcutting Level: " + woodcuttingLevel;

        // Gives a level up notification every 10 levels, and at max level
        if ((woodcuttingLevel % 10 == 0 || woodcuttingLevel == 99) && woodcuttingLevel != lastWoodcuttingLvl) {
            levelUpButton.SetActive(true);
            woodcuttingLevelImage.SetActive(true);
            levelUpText.text = "Congratulations, you just advanced a Woodcutting level. \n" + 
            "Your Woodcutting level is now " + woodcuttingLevel + ". \n" +
            "Click here to continue.";
            lastWoodcuttingLvl = woodcuttingLevel;
        }
    }

    // Get woodcutting level
    public int GetWoodcuttingLevel() {
        return woodcuttingLevel;
    }

    // Closes level up button when user presses it to acknowledge
    public void CloseLevelUpButton() {
        levelUpButton.SetActive(false);
        miningLevelImage.SetActive(false);
        agilityLevelImage.SetActive(false);
        woodcuttingLevelImage.SetActive(false);
    }
}