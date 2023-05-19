using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup : MonoBehaviour
{
    private GameObject adveturerButton;
    private GameObject treasureCardButton;
    private GameObject initialFloodCardButton;

    GameObjects gameobjectsScript;

    private void Awake()
    {
        gameobjectsScript = GameObject.Find("Game Board").GetComponent<GameObjects>();
    }

    void Start()
    {
        gameobjectsScript.AddTilesToList();
        gameobjectsScript.PlaceTilesOnBoard();
        gameobjectsScript.AddTreasureList();
        gameobjectsScript.PlaceTreasureOnBoard();
        gameobjectsScript.AddAdventurersToList();
        gameobjectsScript.AddCardsToTreasureCards();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DealAdventurerCards()
    {
        Vector3 apos1 = new Vector3(-6f, 3f, 0);
        GameObject Adventurer1 = gameobjectsScript.adventurers[Random.Range(0, 6)];
        Adventurer1.transform.position = apos1;
        gameobjectsScript.adventurers.Remove(Adventurer1);

        Vector3 apos2 = new Vector3(6f, 3f, 0);
        GameObject Adventurer2 = gameobjectsScript.adventurers[Random.Range(0, 5)];
        Adventurer2.transform.position = apos2;
        gameobjectsScript.adventurers.Remove(Adventurer2);
    }

    public void DealFirstTwoTreasureCardsAtStart()
    {
        Vector3 tcpos1 = new Vector3(-7.1f, 1.9f, 0);
        GameObject TreasureCard1 = gameobjectsScript.treasureCards[Random.Range(0, 24)];
        TreasureCard1.transform.position = tcpos1;
        gameobjectsScript.treasureCards.Remove(TreasureCard1);

        Vector3 tcpos2 = new Vector3(-6f, 1.9f, 0);
        GameObject TreasureCard2 = gameobjectsScript.treasureCards[Random.Range(0, 23)];
        TreasureCard2.transform.position = tcpos2;
        gameobjectsScript.treasureCards.Remove(TreasureCard2);

        Vector3 tcpos3 = new Vector3(7.1f, 1.9f, 0);
        GameObject TreasureCard3 = gameobjectsScript.treasureCards[Random.Range(0, 22)];
        TreasureCard3.transform.position = tcpos3;
        gameobjectsScript.treasureCards.Remove(TreasureCard3);

        Vector3 tcpos4 = new Vector3(6f, 1.9f, 0);
        GameObject TreasureCard4 = gameobjectsScript.treasureCards[Random.Range(0, 21)];
        TreasureCard4.transform.position = tcpos4;
        gameobjectsScript.treasureCards.Remove(TreasureCard4);
    }

    public void AddWaterRiseCardsToDeck()
    {
        gameobjectsScript.treasureCards.Add(GameObject.Find("Water Rise 1"));
        gameobjectsScript.treasureCards.Add(GameObject.Find("Water Rise 2"));
        gameobjectsScript.treasureCards.Add(GameObject.Find("Water Rise 3"));
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

    public void TilesFlipInitial()
    {
        for (int i = 0; i < 6; i++)
        {
            gameobjectsScript.tilesonBoard[Random.Range(0, 23)].GetComponent<Renderer>().material.color = Color.cyan;
        }
    }

    public void InitialFloodCardButtonDissapears()
    {
        initialFloodCardButton = GameObject.Find("Initial Flood Cards");

        initialFloodCardButton.SetActive(false);
    }
}
