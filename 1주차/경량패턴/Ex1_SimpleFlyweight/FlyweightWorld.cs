using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain_class
{
    int movecost;
    bool iswater;

    public Terrain_class(int cost, bool is_water)
    {
        movecost = cost;
        iswater = is_water;
    }

    public int GetMovecost()
    {
        return movecost;
    }

    public bool IsWater()
    {
        return iswater;
    }
}

//Terrain별로 객체를 하나만들어 동일한 Terrain일 경우 그 객체를 공유
public class FlyweightWorld : MonoBehaviour
{
    int width = 5, height = 5;

    Terrain_class terrain_grass, terrain_hill, terrain_river;
    Terrain_class[,] tiles;

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    private void Init()
    {
        terrain_grass = new Terrain_class(1, false);
        terrain_hill = new Terrain_class(3, false);
        terrain_river = new Terrain_class(2, true);

        tiles = new Terrain_class[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                tiles[x, y] = terrain_grass;
            }
        }

        for (int i = 0; i < 10; i++)
        {
            tiles[Random.Range(0, width), Random.Range(0, height)] = terrain_river;
            tiles[Random.Range(0, width), Random.Range(0, height)] = terrain_hill;
        }
    }
}
