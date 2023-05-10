using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjects : MonoBehaviour
{
    public List<GameObject> treasure = new List<GameObject>();
    public List<GameObject> tiles = new List<GameObject>();
    public List<GameObject> adventurers = new List<GameObject>();
    public List<GameObject> treasureCards = new List<GameObject>();

    public void AddTilesToList()
    {
        tiles.Add(GameObject.Find("Breaker's Bridge"));
        tiles.Add(GameObject.Find("Dunes of Deception"));
        tiles.Add(GameObject.Find("Whispering Garden"));
        tiles.Add(GameObject.Find("Coral Palace"));
        tiles.Add(GameObject.Find("Silver Gate"));
        tiles.Add(GameObject.Find("Twilight Hollow"));
        tiles.Add(GameObject.Find("Bronze Gate"));
        tiles.Add(GameObject.Find("Cave of Embers"));
        tiles.Add(GameObject.Find("Tidal Palace"));
        tiles.Add(GameObject.Find("Observatory"));
        tiles.Add(GameObject.Find("Cliffs of Abandon"));
        tiles.Add(GameObject.Find("Temple of the Moon"));
        tiles.Add(GameObject.Find("Watchtower"));
        tiles.Add(GameObject.Find("Crimson Forest"));
        tiles.Add(GameObject.Find("Copper Gate"));
        tiles.Add(GameObject.Find("Lost Lagoon"));
        tiles.Add(GameObject.Find("Phantom Rock"));
        tiles.Add(GameObject.Find("Iron Gate"));
        tiles.Add(GameObject.Find("Howling Garden"));
        tiles.Add(GameObject.Find("Gold Gate"));
        tiles.Add(GameObject.Find("Misty Marsh"));
        tiles.Add(GameObject.Find("Temple of the Sun"));
        tiles.Add(GameObject.Find("Cave of Shadows"));
        tiles.Add(GameObject.Find("Fool's Landing"));
    }

    public void PlaceTilesOnBoard()
    {
        Vector3 pos1 = new Vector3(-0.6f, 0.6f, 0);
        GameObject firstTile = tiles[Random.Range(0, 24)];
        firstTile.transform.position = pos1;
        tiles.Remove(firstTile);

        Vector3 pos2 = new Vector3(0.6f, 0.6f, 0);
        GameObject secondTile = tiles[Random.Range(0, 23)];
        secondTile.transform.position = pos2;
        tiles.Remove(secondTile);

        Vector3 pos3 = new Vector3(-0.6f, -0.6f, 0);
        GameObject thirdTile = tiles[Random.Range(0, 22)];
        thirdTile.transform.position = pos3;
        tiles.Remove(thirdTile);

        Vector3 pos4 = new Vector3(0.6f, -0.6f, 0);
        GameObject fourthTile = tiles[Random.Range(0, 21)];
        fourthTile.transform.position = pos4;
        tiles.Remove(fourthTile);

        Vector3 pos5 = new Vector3(0.6f, 1.8f, 0);
        GameObject fifthTile = tiles[Random.Range(0, 20)];
        fifthTile.transform.position = pos5;
        tiles.Remove(fifthTile);

        Vector3 pos6 = new Vector3(-0.6f, 1.8f, 0);
        GameObject sixthTile = tiles[Random.Range(0, 19)];
        sixthTile.transform.position = pos6;
        tiles.Remove(sixthTile);

        Vector3 pos7 = new Vector3(-0.6f, -1.8f, 0);
        GameObject seventhTile = tiles[Random.Range(0, 18)];
        seventhTile.transform.position = pos7;
        tiles.Remove(seventhTile);

        Vector3 pos8 = new Vector3(0.6f, -1.8f, 0);
        GameObject eighthTile = tiles[Random.Range(0, 17)];
        eighthTile.transform.position = pos8;
        tiles.Remove(eighthTile);

        Vector3 pos9 = new Vector3(-1.8f, 0.6f, 0);
        GameObject ninthTile = tiles[Random.Range(0, 16)];
        ninthTile.transform.position = pos9;
        tiles.Remove(ninthTile);

        Vector3 pos10 = new Vector3(-1.8f, -0.6f, 0);
        GameObject tenthTile = tiles[Random.Range(0, 15)];
        tenthTile.transform.position = pos10;
        tiles.Remove(tenthTile);

        Vector3 pos11 = new Vector3(1.8f, 0.6f, 0);
        GameObject eleventhTile = tiles[Random.Range(0, 14)];
        eleventhTile.transform.position = pos11;
        tiles.Remove(eleventhTile);

        Vector3 pos12 = new Vector3(1.8f, -0.6f, 0);
        GameObject twelveTile = tiles[Random.Range(0, 13)];
        twelveTile.transform.position = pos12;
        tiles.Remove(twelveTile);

        Vector3 pos13 = new Vector3(-1.8f, 1.8f, 0);
        GameObject thirteenthTile = tiles[Random.Range(0, 12)];
        thirteenthTile.transform.position = pos13;
        tiles.Remove(thirteenthTile);

        Vector3 pos14 = new Vector3(-1.8f, -1.8f, 0);
        GameObject fourteenthTile = tiles[Random.Range(0, 11)];
        fourteenthTile.transform.position = pos14;
        tiles.Remove(fourteenthTile);

        Vector3 pos15 = new Vector3(1.8f, 1.8f, 0);
        GameObject fifteenthTile = tiles[Random.Range(0, 10)];
        fifteenthTile.transform.position = pos15;
        tiles.Remove(fifteenthTile);

        Vector3 pos16 = new Vector3(1.8f, -1.8f, 0);
        GameObject sixteenthTile = tiles[Random.Range(0, 9)];
        sixteenthTile.transform.position = pos16;
        tiles.Remove(sixteenthTile);

        Vector3 pos17 = new Vector3(-0.6f, 3f, 0);
        GameObject seventeenthTile = tiles[Random.Range(0, 8)];
        seventeenthTile.transform.position = pos17;
        tiles.Remove(seventeenthTile);

        Vector3 pos18 = new Vector3(0.6f, 3f, 0);
        GameObject eighteenthTile = tiles[Random.Range(0, 7)];
        eighteenthTile.transform.position = pos18;
        tiles.Remove(eighteenthTile);

        Vector3 pos19 = new Vector3(-0.6f, -3f, 0);
        GameObject nineteenthTile = tiles[Random.Range(0, 6)];
        nineteenthTile.transform.position = pos19;
        tiles.Remove(nineteenthTile);

        Vector3 pos20 = new Vector3(0.6f, -3f, 0);
        GameObject twentiethTile = tiles[Random.Range(0, 5)];
        twentiethTile.transform.position = pos20;
        tiles.Remove(twentiethTile);

        Vector3 pos21 = new Vector3(-3f, 0.6f, 0);
        GameObject twentyfirstTile = tiles[Random.Range(0, 4)];
        twentyfirstTile.transform.position = pos21;
        tiles.Remove(twentyfirstTile);

        Vector3 pos22 = new Vector3(-3f, -0.6f, 0);
        GameObject twentysecondTile = tiles[Random.Range(0, 3)];
        twentysecondTile.transform.position = pos22;
        tiles.Remove(twentysecondTile);

        Vector3 pos23 = new Vector3(3f, 0.6f, 0);
        GameObject twentythirdTile = tiles[Random.Range(0, 2)];
        twentythirdTile.transform.position = pos23;
        tiles.Remove(twentythirdTile);

        Vector3 pos24 = new Vector3(3f, -0.6f, 0);
        GameObject twentyfourthTile = tiles[Random.Range(0, 1)];
        twentyfourthTile.transform.position = pos24;
        tiles.Remove(twentyfourthTile);

    }

    public void AddTreasureList()
    {
        treasure.Add(GameObject.Find("The Earth Stone"));
        treasure.Add(GameObject.Find("The Statue of the Wind"));
        treasure.Add(GameObject.Find("The Crystal of Fire"));
        treasure.Add(GameObject.Find("The Ocean's Chalice"));
    }

    public void PlaceTreasureOnBoard()
    {
        Vector3 tpos1 = new Vector3(-3f, 4.2f, 0);
        GameObject firstTreasure = treasure[0];
        firstTreasure.transform.position = tpos1;
        

        Vector3 tpos2 = new Vector3(3f, 4.2f, 0);
        GameObject secondTreasure = treasure[1];
        secondTreasure.transform.position = tpos2;
        

        Vector3 tpos3 = new Vector3(-3f, -4.2f, 0);
        GameObject thirdTreasure = treasure[2];
        thirdTreasure.transform.position = tpos3;
        

        Vector3 tpos4 = new Vector3(3f, -4.2f, 0);
        GameObject fourthTreasure = treasure[3];
        fourthTreasure.transform.position = tpos4;
       
    }

    public void AddAdventurersToList()
    {
        adventurers.Add(GameObject.Find("Explorer"));
        adventurers.Add(GameObject.Find("Pilot"));
        adventurers.Add(GameObject.Find("Navigator"));
        adventurers.Add(GameObject.Find("Diver"));
        adventurers.Add(GameObject.Find("Engineer"));
        adventurers.Add(GameObject.Find("Messenger"));
    }

    public void AddCardsToTreasureCards()
    {
        treasureCards.Add(GameObject.Find("The Earth Stone 1"));
        treasureCards.Add(GameObject.Find("The Earth Stone 2"));
        treasureCards.Add(GameObject.Find("The Earth Stone 3"));
        treasureCards.Add(GameObject.Find("The Earth Stone 4"));
        treasureCards.Add(GameObject.Find("The Earth Stone 5"));
        treasureCards.Add(GameObject.Find("The Statue of the Wind 1"));
        treasureCards.Add(GameObject.Find("The Statue of the Wind 2"));
        treasureCards.Add(GameObject.Find("The Statue of the Wind 3"));
        treasureCards.Add(GameObject.Find("The Statue of the Wind 4"));
        treasureCards.Add(GameObject.Find("The Statue of the Wind 5"));
        treasureCards.Add(GameObject.Find("The Crystal of Fire 1"));
        treasureCards.Add(GameObject.Find("The Crystal of Fire 2"));
        treasureCards.Add(GameObject.Find("The Crystal of Fire 3"));
        treasureCards.Add(GameObject.Find("The Crystal of Fire 4"));
        treasureCards.Add(GameObject.Find("The Crystal of Fire 5"));
        treasureCards.Add(GameObject.Find("The Ocean's Chalice 1"));
        treasureCards.Add(GameObject.Find("The Ocean's Chalice 2"));
        treasureCards.Add(GameObject.Find("The Ocean's Chalice 3"));
        treasureCards.Add(GameObject.Find("The Ocean's Chalice 4"));
        treasureCards.Add(GameObject.Find("The Ocean's Chalice 5"));
        treasureCards.Add(GameObject.Find("Helicopter Lift 1"));
        treasureCards.Add(GameObject.Find("Helicopter Lift 2"));
        treasureCards.Add(GameObject.Find("Helicopter Lift 3"));
        treasureCards.Add(GameObject.Find("Sandbag 1"));
        treasureCards.Add(GameObject.Find("Sandbag 2"));
    }
}
