/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjects : MonoBehaviour
{
    public List<GameObject> treasure = new List<GameObject>();
    public List<GameObject> tiles = new List<GameObject>();
    public List<GameObject> tilesonBoard = new List<GameObject>();
    public List<GameObject> adventurers = new List<GameObject>();
    public List<GameObject> treasureCards = new List<GameObject>();

    public List<GameObject> treasureCardsDiscard = new List<GameObject>();
    public List<GameObject> tilesDiscard = new List<GameObject>();

    private List<GameObject> remainingTreasureCards = new List<GameObject>();

    public void AddTilesToList()
    {
        // Existing code...
    }

    public void PlaceTilesOnBoard()
    {
        // Existing code...
    }

    public void AddTreasureList()
    {
        // Existing code...
    }

    public void PlaceTreasureOnBoard()
    {
        // Existing code...
    }

    public void AddAdventurersToList()
    {
        // Existing code...
    }

    public void AddCardsToTreasureCards()
    {
        // Existing code...
    }

    private void AddRemainingTreasureCards()
    {
        remainingTreasureCards.AddRange(treasureCards);
    }

    private void ReshuffleTreasureCards()
    {
        int cardCount = remainingTreasureCards.Count;

        for (int i = 0; i < cardCount; i++)
        {
            GameObject card = remainingTreasureCards[i];
            int randomIndex = Random.Range(i, cardCount);
            remainingTreasureCards[i] = remainingTreasureCards[randomIndex];
            remainingTreasureCards[randomIndex] = card;
        }
    }

    public void DiscardTreasureCard(GameObject card)
    {
        treasureCards.Remove(card);
        treasureCardsDiscard.Add(card);
    }

    public GameObject DrawTreasureCard()
    {
        if (remainingTreasureCards.Count == 0)
        {
            Debug.Log("No more treasure cards remaining. Reshuffling the discard pile.");
            ReshuffleDiscardedTreasureCards();
        }

        GameObject card = remainingTreasureCards[0];
        remainingTreasureCards.RemoveAt(0);
        return card;
    }

    private void ReshuffleDiscardedTreasureCards()
    {
        remainingTreasureCards.AddRange(treasureCardsDiscard);
        treasureCardsDiscard.Clear();
        ReshuffleTreasureCards();
    }

    void Start()
    {
        AddTilesToList();
        PlaceTilesOnBoard();
        AddTreasureList();
        PlaceTreasureOnBoard();
        AddAdventurersToList();
        AddCardsToTreasureCards();
        AddRemainingTreasureCards();
        ReshuffleTreasureCards();
    }

    void Update()
    {
        // Existing code...
    }
}
*/



// This code focuses on the game objects, tiles, treasures, and the management of treasure cards.  add the player-related functionality separately in your player script.