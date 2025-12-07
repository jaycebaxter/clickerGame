using UnityEngine;
using UnityEngine.UI;

public class GameEvents : MonoBehaviour
{
    public GameObject selectSkillButton;
    public GameObject miningButton;
    public GameObject woodcuttingButton;
    public GameObject agilityButton;

    public GameObject GEImage;


    public Text miningXPLabel;
    private float xp = 0f;

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
        UpdateXPLabel();
    }

    // Mining button clicked
    public void MiningClicked()
    {     
        GEImage.SetActive(false);
    }

    public void AddXP(float amount)
    {
        xp += amount;
        UpdateXPLabel();
    }

    public void UpdateXPLabel()
    {
        miningXPLabel.text = "XP: " + xp;
    }
}
