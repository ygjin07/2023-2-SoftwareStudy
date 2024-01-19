using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Switch를 이용하여 어떤 Terrain인지를 확인하고 그에 대한 정보를 return한다.
public class SimpleWorld : MonoBehaviour
{
    enum Terrain_enum
    {
        TERRAIN_GRASS,
        TERRAIN_HILL,
        TERRAIN_RIVER
    };

    int width = 5, height = 5;

    Terrain_enum[,] tiles;

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    private void Init()
    {
        tiles = new Terrain_enum[width, height];

        for(int x = 0; x < width; x++)
        {
            for(int y = 0; y<height;y++)
            {
                tiles[x, y] = Terrain_enum.TERRAIN_GRASS;
            }
        }

        for(int i = 0;i<10;i++)
        {
            tiles[Random.Range(0, width), Random.Range(0, height)] = Terrain_enum.TERRAIN_RIVER;
            tiles[Random.Range(0, width), Random.Range(0, height)] = Terrain_enum.TERRAIN_HILL;
        }
    }

    //지형을 이동할때의 비용
    public int GetMoveCost(int x, int y)
    {
        switch(tiles[x, y])
        {
            case Terrain_enum.TERRAIN_GRASS:
                return 1;
            case Terrain_enum.TERRAIN_HILL:
                return 3;
            case Terrain_enum.TERRAIN_RIVER:
                return 2;
        }
        return -1;
    }

    //물인지 아닌지 확인
    public bool isWater(int x, int y)
    {
        switch (tiles[x, y])
        {
            case Terrain_enum.TERRAIN_GRASS:
                return false;
            case Terrain_enum.TERRAIN_HILL:
                return false;
            case Terrain_enum.TERRAIN_RIVER:
                return true;
        }
        return false;
    }
}
