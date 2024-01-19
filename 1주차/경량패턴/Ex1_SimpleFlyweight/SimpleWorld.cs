using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Switch�� �̿��Ͽ� � Terrain������ Ȯ���ϰ� �׿� ���� ������ return�Ѵ�.
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

    //������ �̵��Ҷ��� ���
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

    //������ �ƴ��� Ȯ��
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
