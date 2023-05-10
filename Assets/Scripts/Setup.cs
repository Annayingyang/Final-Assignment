using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup : GameObjects
{
    private GameObject adveturerButton;
    private GameObject treasureCardButton;
    // Start is called before the first frame update
    void Start()
    {
        AddTilesToList();
        PlaceTilesOnBoard();
        AddTreasureList();
        PlaceTreasureOnBoard();
        AddAdventurersToList();
        AddCardsToTreasureCards();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealAdventurerCards()
    {
        Vector3 apos1 = new Vector3(-6f, 3f, 0);
        GameObject Adventurer1 = adventurers[Random.Range(0, 6)];
        Adventurer1.transform.position = apos1;
        adventurers.Remove(Adventurer1);

        Vector3 apos2 = new Vector3(6f, 3f, 0);
        GameObject Adventurer2 = adventurers[Random.Range(0, 5)];
        Adventurer2.transform.position = apos2;
        adventurers.Remove(Adventurer2);
    }

    public void DealFirstTwoTreasureCardsAtStart()
    {
        Vector3 tcpos1 = new Vector3(-7.1f, 1.9f, 0);
        GameObject TreasureCard1 = treasureCards[Random.Range(0, 24)];
        TreasureCard1.transform.position = tcpos1;
        treasureCards.Remove(TreasureCard1);

        Vector3 tcpos2 = new Vector3(-6f, 1.9f, 0);
        GameObject TreasureCard2 = treasureCards[Random.Range(0, 23)];
        TreasureCard2.transform.position = tcpos2;
        treasureCards.Remove(TreasureCard2);

        Vector3 tcpos3 = new Vector3(7.1f, 1.9f, 0);
        GameObject TreasureCard3 = treasureCards[Random.Range(0, 22)];
        TreasureCard3.transform.position = tcpos3;
        treasureCards.Remove(TreasureCard3);

        Vector3 tcpos4 = new Vector3(6f, 1.9f, 0);
        GameObject TreasureCard4 = treasureCards[Random.Range(0, 21)];
        TreasureCard4.transform.position = tcpos4;
        treasureCards.Remove(TreasureCard4);
    }

    public void AddWaterRiseCardsToDeck()
    {
        treasureCards.Add(GameObject.Find("Water Rise 1"));
        treasureCards.Add(GameObject.Find("Water Rise 2"));
        treasureCards.Add(GameObject.Find("Water Rise 3"));
    }

    public void AdventurerButtonDissapears()
    {
        adveturerButton = GameObject.Find("Adventurercards");

        adveturerButton.SetActive(false);
    }

    public void TreasureCardButtonDissapears()
    {
        treasureCardButton = GameObject.Find("Treasure Cards");

        treasureCardButton.SetActive(false);
    }
}
