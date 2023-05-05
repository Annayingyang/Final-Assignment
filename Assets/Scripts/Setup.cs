using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup : GameObjects
{
    // Start is called before the first frame update
    void Start()
    {
        AddTilesToList();
        PlaceTilesOnBoard();
        AddTreasureList();
        PlaceTreasureOnBoard();
        AddAdventurersToList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealAdventurerCards()
    {
        Vector3 apos1 = new Vector3(-8f, 2f, 0);
        GameObject Adventurer1 = adventurers[Random.Range(0, 6)];
        Adventurer1.transform.position = apos1;
        adventurers.Remove(Adventurer1);

        Vector3 apos2 = new Vector3(8f, 2f, 0);
        GameObject Adventurer2 = adventurers[Random.Range(0, 5)];
        Adventurer2.transform.position = apos2;
        adventurers.Remove(Adventurer2);
    }
}
