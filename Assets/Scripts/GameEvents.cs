using UnityEngine;
using UnityEngine.UI;

public class GameEvents : MonoBehaviour
{
    public GameObject selectSkillButton;
    public GameObject miningButton;
    public GameObject woodcuttingButton;
    public GameObject agilityButton;

    public GameObject GEImage;
    public Text miningLevelLabel;
    public Text miningXPLabel;
    public Text agilityLevelLabel;
    public Text agilityXPLabel;
    public Text woodcuttingLevelLabel;
    public Text woodcuttingXPLabel;

    private float miningXP = 0f;
    private float agilityXP = 0f;
    private float woodcuttingXP = 0f;

    private static float baseMiningXP = 83f;
    private static float baseAgilityXP = 83f;
    private static float baseWoodcuttingXP = 83f;
    private float nextMiningXP = baseMiningXP;
    private float nextAgilityXP = baseAgilityXP;
    private float nextWoodcuttingXP = baseWoodcuttingXP;
    private float growth = 1.1040895f;

    public Mining mining;

    // Used for when the game first starts and only the select skills button is available
    public void ResetGame()
    {
        selectSkillButton.SetActive(true);
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
        UpdateMiningXPLabel();
        // UpdateAgilityXPLabel();
        // UpdateWoodcuttingXPLabel();
    }

    public void AddMiningXP(float amount)
    {
        miningXP += amount;
        UpdateMiningXPLabel();
        UpdateMiningLevel();
        mining.Unlock();
    }

    public void AddAgilityXP(float amount)
    {
        agilityXP += amount;
        // UpdateAgilityXPLabel();
        // UpdateAgilityLevel();
        // agility.Unlock();
    }

    // Mining xp
    public void UpdateMiningXPLabel()
    {
        miningXPLabel.text = "Mining XP: " + miningXP;
    }

    public void UpdateAgilityXPLabel()
    {
        agilityXPLabel.text = "Agility XP: " + agilityXP;
    }

    // Updates mining level
    public void UpdateMiningLevel() {
        float nextMiningXP = baseMiningXP;
        int miningLevel = 1;

        while (miningXP >= nextMiningXP && miningLevel < 99) {
            miningLevel++;
            nextMiningXP += baseMiningXP * Mathf.Pow(growth, miningLevel - 2);
        }
        miningLevelLabel.text = "Mining Level: " + miningLevel;
    }

    public int GetMiningLevel() {
        return int.Parse(miningLevelLabel.text.Split(' ')[2]);
    }
}
