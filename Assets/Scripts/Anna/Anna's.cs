/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjects : MonoBehaviour
{
    // Existing code...

    // List to store the discarded treasure cards
    public List<GameObject> treasureCardsDiscard = new List<GameObject>();

    // List to store the remaining treasure cards
    private List<GameObject> remainingTreasureCards = new List<GameObject>();

    // Method to add the treasure cards to the remainingTreasureCards list
    private void AddRemainingTreasureCards()
    {
        remainingTreasureCards.AddRange(treasureCards);
    }

    // Method to reshuffle the treasure cards
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

    // Method to discard a treasure card
    public void DiscardTreasureCard(GameObject card)
    {
        treasureCards.Remove(card);
        treasureCardsDiscard.Add(card);
    }

    // Method to draw a treasure card from the remainingTreasureCards list
    public GameObject DrawTreasureCard()
    {
        if (remainingTreasureCards.Count == 0)
        {
            Debug.Log("No more treasure cards remaining.");
            return null;
        }

        GameObject card = remainingTreasureCards[0];
        remainingTreasureCards.RemoveAt(0);
        return card;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Add the treasure cards to the remainingTreasureCards list
        AddRemainingTreasureCards();

        // Reshuffle the treasure cards
        ReshuffleTreasureCards();

        // Existing code...
    }

    // Update is called once per frame
    void Update()
    {
        // Existing code...
    }

    // Existing methods...
}
*/