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

    public GameObject draynorButton;
    public GameObject alKharidButton;
    public GameObject varrockButton;
    public GameObject canifisButton;
    public GameObject faladorButton;
    public GameObject seersButton;
    public GameObject pollnivButton;
    public GameObject rellekkaButton;
    public GameObject ardougneButton;

    public void ShowRooftops() {
        GEImage.SetActive(false);
        rooftopImage.SetActive(true);
        draynorButton.SetActive(true);
    }


    public void Unlock() {
    if (gameEvents.GetAgilityLevel() >=20) {
        alKharidButton.SetActive(true);
    }
    }

    // public void CopperClicked()
    // {
    //     gameEvents.AddMiningXP(17.5f);
    // }

    
}