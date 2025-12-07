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

    public void ShowOres() {
        copperButton.SetActive(true);
        // ironButton.SetActive(true);
        // silverButton.SetActive(true);
        // coalButton.SetActive(true);
        // goldButton.SetActive(true);
        // mithrilButton.SetActive(true);
        // adamantiteButton.SetActive(true);
        // runiteButton.SetActive(true);
        // amethystButton.SetActive(true);

        GEImage.SetActive(false);
    }

    public void CopperClicked()
    {
        gameEvents.AddXP(17.5f);
    }

    public void IronClicked()
    {
        gameEvents.AddXP(35f);
    }

    public void SilverClicked() {
        gameEvents.AddXP(40f);
    }

    public void CoalClicked() {
        gameEvents.AddXP(50f);
    }
    
    public void GoldClicked() {
        gameEvents.AddXP(65f);
    }

    public void MithrilClicked() {
        gameEvents.AddXP(80f);
    }

    public void AdamantiteClicked() {
        gameEvents.AddXP(95f);
    }

    public void RuniteClicked() {
        gameEvents.AddXP(125f);
    }

    public void AmethystClicked() {
        gameEvents.AddXP(240f);
    }
}
