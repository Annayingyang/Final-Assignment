using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjects : MonoBehaviour
{
    public List<GameObject> treasure = new List<GameObject>();
    public List<GameObject> tiles = new List<GameObject>();
    public List<GameObject> adventurers = new List<GameObject>();

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
        Vector3[] positions = new Vector3[24]
        {
        new Vector3(-0.6f, 0.6f, 0),
        new Vector3(0.6f, 0.6f, 0),
        new Vector3(-0.6f, -0.6f, 0),
        new Vector3(0.6f, -0.6f, 0),
        new Vector3(0.6f, 1.8f, 0),
        new Vector3(-0.6f, 1.8f, 0),
        new Vector3(-0.6f, -1.8f, 0),
        new Vector3(0.6f, -1.8f, 0),
        new Vector3(-1.8f, 0.6f, 0),
        new Vector3(-1.8f, -0.6f, 0),
        new Vector3(1.8f, 0.6f, 0),
        new Vector3(1.8f, -0.6f, 0),
        new Vector3(-1.8f, 1.8f, 0),
        new Vector3(-1.8f, -1.8f, 0),
        new Vector3(1.8f, 1.8f, 0),
        new Vector3(1.8f, -1.8f, 0),
        new Vector3(-0.6f, 3f, 0),
        new Vector3(0.6f, 3f, 0),
        new Vector3(-0.6f, -3f, 0),
        new Vector3(0.6f, -3f, 0),
        new Vector3(-3f, 0.6f, 0),
        new Vector3(-3f, -0.6f, 0),
        new Vector3(3f, 0.6f, 0),
        new Vector3(3f, -0.6f, 0)
        };

        for (int i = 0; i < 24; i++)
        {
            int randomIndex = Random.Range(0, tiles.Count);
            GameObject tile = tiles[randomIndex];
            tile.transform.position = positions[i];
            tiles.RemoveAt(randomIndex);
        }
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

    
}
