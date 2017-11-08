using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelView : MonoBehaviour
{
    public GameObject tilePrefab;
   // public GameObject tileContainerGO;
    private LevelModel levelModel;
    public int mapSize;
    public GameObject[,] tiles;
    public float tileOutline;
    public GameObject tileClones;
  //  public Vector3[] tilePositions;
    List<Vector3> positionZ;

    GameObject newTile;
    Vector3 tilePosition;
   
    void Start()
    {
        DisplayMap();  
    }

    public void SetModel(LevelModel levelModel)
    {
        this.mapSize = levelModel.GetMapSize();
        this.tiles = new GameObject[mapSize,mapSize];
        this.levelModel = levelModel;
    }

    public void DisplayMap()
    {
        for (int x=0; x < mapSize; x++)
        {
            for (int y=0; y < mapSize; y++)
            {
                CreateTile(x,y);
            }
        }
    }

    public void SetParent(GameObject TileClones2)
    {
        newTile.transform.parent= TileClones2.transform;
    }

    private void CreateTile(int x, int y)
    {
        newTile = (GameObject)Instantiate(tilePrefab) as GameObject;
        Vector3 tilePosition = new Vector3(x + 0.5f, 0, y + 0.5f);
        newTile.transform.position = tilePosition;
        //SetParent(findTileClones);
        // newTile.localScale = Vector3.one * (1 - tileOutline);
;
       // newTile.transform.parent = tileContainerGO.transform;
    }

    public void DestroyTiles()
    {
        var clones = GameObject.FindGameObjectsWithTag("clone");
        foreach (var clone in clones)
        {
            Destroy(clone);
        }
    }

    void positionOfTile()
    {
      var  tilePosition = GameObject.FindGameObjectsWithTag("clone");
        foreach (var pos in tilePosition)
        {
           // tilePositions[pos];
        }
    }
}

