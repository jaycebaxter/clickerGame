// Program: OSRS Clicker
// Author: Jayce Baxter-Johnson
// Date: December 7th, 2025
// Description: Allows the user to play a cookie clicker style game
//              based on Oldschool Runescape, with 3 skills to train:
//              Mining, Woodcutting, and Agility.

using UnityEngine;

public class Mining : MonoBehaviour
{
    public GameEvents gameEvents;

    public GameObject agilityButton;
    public GameObject woodcuttingButton;
    public GameObject miningButton;
    
    public GameObject GEImage;
    public GameObject miningImage;
    public GameObject agilityImage;
    public GameObject woodcuttingImage;

    public GameObject copperButton;
    public GameObject ironButton;
    public GameObject silverButton;
    public GameObject coalButton;
    public GameObject goldButton;
    public GameObject mithrilButton;
    public GameObject adamantiteButton;
    public GameObject runiteButton;
    public GameObject amethystButton;

    public Agility agility;
    public Woodcutting woodcutting;

    // Reset / default state
    public void Start() {
        HideOres();
        agility.HideRooftops();
        woodcutting.HideTrees();
    }

    // Shows mining UI and hides UI from other skills
    public void ShowOres() {
        copperButton.SetActive(true);
        GEImage.SetActive(false);
        agilityImage.SetActive(false);
        woodcuttingImage.SetActive(false);
        miningImage.SetActive(true);
        agility.HideRooftops();
        woodcutting.HideTrees();
        UnlockOres();
    }

    // Hides all ores, used for woodcutting and agility
    public void HideOres() {
        copperButton.SetActive(false);
        ironButton.SetActive(false);
        silverButton.SetActive(false);
        coalButton.SetActive(false);
        goldButton.SetActive(false);
        mithrilButton.SetActive(false);
        adamantiteButton.SetActive(false);
        runiteButton.SetActive(false);
        amethystButton.SetActive(false);
    }

    // Unlocks ores based on mining level
    public void UnlockOres() {
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

    // Adds xp based on ore mined
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
