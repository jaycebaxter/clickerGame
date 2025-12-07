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
    }

    // Select skill button clicked 
    public void SelectSkillClicked()
    {
        selectSkillButton.SetActive(false);
        miningButton.SetActive(true);
        woodcuttingButton.SetActive(true);
        agilityButton.SetActive(true);
    }

    public void AddMiningXP(float amount)
    {
        miningXP += amount;
        UpdateMiningXPLabel();
        UpdateMiningLevel();
        mining.UnlockOres();
    }

    public void AddAgilityXP(float amount)
    {
        agilityXP += amount;
        UpdateAgilityXPLabel();
        UpdateAgilityLevel();
        agility.UnlockRooftops();
    }

    public void AddWoodcuttingXP(float amount)
    {
        woodcuttingXP += amount;
        UpdateWoodcuttingLevel();
        UpdateWoodcuttingXPLabel();
        woodcutting.UnlockTrees();
    }

    // Mining xp
    public void UpdateMiningXPLabel()
    {
        miningXPLabel.text = "Mining XP: " + miningXP;
    }

    // Agility xp
    public void UpdateAgilityXPLabel()
    {
        agilityXPLabel.text = "Agility XP: " + agilityXP;
    }
    
    // Woodcutting xp
    public void UpdateWoodcuttingXPLabel()
    {
        woodcuttingXPLabel.text = "Woodcutting XP: " + woodcuttingXP;
    }


    // Updates mining level
    public void UpdateMiningLevel() {
        float nextMiningXP = baseMiningXP;
        int newMiningLevel = 1;

        while (miningXP >= nextMiningXP && newMiningLevel < 99) {
            newMiningLevel++;
            nextMiningXP += baseMiningXP * Mathf.Pow(growth, newMiningLevel - 2);
        }
        
        miningLevel = newMiningLevel;
        miningLevelLabel.text = "Mining Level: " + miningLevel;

        
        if (miningLevel % 10 == 0 || miningLevel == 99) {
            levelUpButton.SetActive(true);
            levelUpText.text = "Congratulations, you just advanced a Mining level. \n" + 
            "Your Mining level is now " + miningLevel + ".";
        }
    }

    // Get mining level
    public int GetMiningLevel() {
        return miningLevel;
    }

    // Updates agility level
    public void UpdateAgilityLevel() {
        float nextAgilityXP = baseAgilityXP;
        int newAgilityLevel = 1;

        while (agilityXP >= nextAgilityXP && newAgilityLevel < 99) {
            newAgilityLevel++;
            nextAgilityXP += baseAgilityXP * Mathf.Pow(growth, newAgilityLevel - 2);
        }
        
        agilityLevel = newAgilityLevel;
        agilityLevelLabel.text = "Agility Level: " + agilityLevel;

        
        if (agilityLevel % 10 == 0 || agilityLevel == 99) {
            levelUpButton.SetActive(true);
            levelUpText.text = "Congratulations, you just advanced an Agility level. \n" + 
            "Your Agility level is now " + agilityLevel + ".";
        }
    }

    public int GetAgilityLevel() {
        return agilityLevel;
    }

    
    // Updates woodcutting level
    public void UpdateWoodcuttingLevel() {
        float nextWoodcuttingXP = baseWoodcuttingXP;
        int newWoodcuttingLevel = 1;

        while (woodcuttingXP >= nextWoodcuttingXP && newWoodcuttingLevel < 99) {
            newWoodcuttingLevel++;
            nextWoodcuttingXP += baseWoodcuttingXP * Mathf.Pow(growth, newWoodcuttingLevel - 2);
        }
        
        woodcuttingLevel = newWoodcuttingLevel;
        woodcuttingLevelLabel.text = "Woodcutting Level: " + woodcuttingLevel;

        if (woodcuttingLevel % 10 == 0 || woodcuttingLevel == 99) {
            levelUpButton.SetActive(true);
            levelUpText.text = "Congratulations, you just advanced a Woodcutting level. \n" + 
            "Your Woodcutting level is now " + woodcuttingLevel + ".";
        }

        Debug.Log("Woodcutting XP: " + woodcuttingXP + " Level: " + woodcuttingLevel);
    }

    public int GetWoodcuttingLevel() {
        return woodcuttingLevel;
    }

}
