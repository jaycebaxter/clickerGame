using UnityEngine;

public class Mining : MonoBehaviour
{
    public GameEvents gameEvents;

    public GameObject copperButton;
    public GameObject ironButton;
    public GameObject silverButton;
    public GameObject coalButton;
    public GameObject goldButton;
    public GameObject mithrilButton;
    public GameObject adamantiteButton;
    public GameObject runiteButton;
    public GameObject amethystButton;

    public GameObject agilityButton;
    public GameObject woodcuttingButton;
    public GameObject miningButton;

    public GameObject GEImage;
    public GameObject miningImage;

    public void ShowOres() {
        copperButton.SetActive(true);
        GEImage.SetActive(false);
        miningImage.SetActive(true);
    }

    public void Unlock() {
    if (gameEvents.GetMiningLevel() >=15) {
        ironButton.SetActive(true);
    }

    if (gameEvents.GetMiningLevel() >=20) {
            silverButton.SetActive(true);
    }

    if (gameEvents.GetMiningLevel() >=30) {
            coalButton.SetActive(true);
    }

    if (gameEvents.GetMiningLevel() >=40) {
            goldButton.SetActive(true);
    }

    if (gameEvents.GetMiningLevel() >=55) {
            mithrilButton.SetActive(true);
    }

    if (gameEvents.GetMiningLevel() >=70) {
            adamantiteButton.SetActive(true);
    }

    if (gameEvents.GetMiningLevel() >=85) {
            runiteButton.SetActive(true);
    }

    if (gameEvents.GetMiningLevel() >=92) {
            amethystButton.SetActive(true);
    }
    }

    public void CopperClicked()
    {
        gameEvents.AddMiningXP(17.5f);
    }

    public void IronClicked()
    {
        gameEvents.AddMiningXP(35f);
    }

    public void SilverClicked() {
        gameEvents.AddMiningXP(40f);
    }

    public void CoalClicked() {
        gameEvents.AddMiningXP(50f);
    }
    
    public void GoldClicked() {
        gameEvents.AddMiningXP(65f);
    }

    public void MithrilClicked() {
        gameEvents.AddMiningXP(80f);
    }

    public void AdamantiteClicked() {
        gameEvents.AddMiningXP(95f);
    }

    public void RuniteClicked() {
        gameEvents.AddMiningXP(125f);
    }

    public void AmethystClicked() {
        gameEvents.AddMiningXP(240f);
    }

    
}
