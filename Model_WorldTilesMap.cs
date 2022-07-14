using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class Model_WorldTilesMap
{
    const int TilesPerRow = 3;
    public Model_WorldTilesRow[] worldTilesRows = new Model_WorldTilesRow[TilesPerRow];

    public int Length
    {
        get => worldTilesRows.Length;
    }

    // Player moves down a world tile.
    public Model_WorldTilesRow[] ShiftTilesDown()
    {
        Model_WorldTilesRow[] rows          = new Model_WorldTilesRow[3];
        for (int i = 0; i < rows.Length; i++)   rows[i] = new Model_WorldTilesRow();

        // Store new row shifted up.
        for (int i = 1; i < worldTilesRows.Length; i++)
        {
            rows[i - 1] = worldTilesRows[i];
        }
        
        // Move the shifted off first row to the new last row.
        for (int i = 0; i < rows[rows.Length - 1].tilesData.Length; i++)
        {
            rows[rows.Length - 1].tilesData[i] = worldTilesRows[0].tilesData[i];
            
            // Transform the respective tile in World Space to be in Sync with Map
            worldTilesRows[0].tilesData[i].Move(new Vector2Int(0, -TilesPerRow));
        }

        worldTilesRows = rows;
        return worldTilesRows;
    }

    // Player moves up a world tile.
    public Model_WorldTilesRow[] ShiftTilesUp()
    {
        Model_WorldTilesRow[] rows          = new Model_WorldTilesRow[3];
        for (int i = 0; i < rows.Length; i++)   rows[i] = new Model_WorldTilesRow();

        // Create new Map with moved Rows.
        for (int i = 1; i < worldTilesRows.Length; i++)
        {
            rows[i] = worldTilesRows[i - 1];
        }
        
        // Move the shifted off last row to the new first row.
        for (int i = 0; i < rows[0].tilesData.Length; i++)
        {
            rows[0].tilesData[i] = worldTilesRows[worldTilesRows.Length - 1].tilesData[i];

            // Transform the respective tile in World Space to be in Sync with Map
            worldTilesRows[worldTilesRows.Length - 1].tilesData[i].Move(new Vector2Int(0, TilesPerRow));
        }

        worldTilesRows = rows;
        
        return worldTilesRows;
    }

    // Player moves left a world tile.
    public Model_WorldTilesRow[] ShiftTilesLeft()
    {
        Model_WorldTilesRow[] rows          = new Model_WorldTilesRow[3];
        for (int i = 0; i < rows.Length; i++)   rows[i] = new Model_WorldTilesRow();

        // Create new Map with moved Rows.
        for (int i = 0; i < worldTilesRows.Length; i++)
        {
            for (int j = 1; j < worldTilesRows[i].tilesData.Length; j++)
            {
                rows[i].tilesData[j] = worldTilesRows[i].tilesData[j - 1];
            }

            // Move last element in row that is moved off Map as the new first element.
            rows[i].tilesData[0] = worldTilesRows[i].tilesData[worldTilesRows[i].tilesData.Length - 1];

            // Transform the respective tile in World Space to be in Sync with Map
            worldTilesRows[i].tilesData[worldTilesRows[i].tilesData.Length - 1].Move(new Vector2(-TilesPerRow, 0));
        }

        worldTilesRows = rows;
        
        return worldTilesRows;    
    }

    // Player moves right a world tile.
    public Model_WorldTilesRow[] ShiftTilesRight()
    {
        Model_WorldTilesRow[] rows          = new Model_WorldTilesRow[3];
        for (int i = 0; i < rows.Length; i++)   rows[i] = new Model_WorldTilesRow();

        // Create new Map with moved Rows.
        for (int i = 0; i < worldTilesRows.Length; i++)
        {
            for (int j = 1; j < worldTilesRows[i].tilesData.Length; j++)
            {
                rows[i].tilesData[j - 1] = worldTilesRows[i].tilesData[j];
            }

            // Move first element in row that is moved off Map as the new last element.
            rows[i].tilesData[rows[i].tilesData.Length - 1] = worldTilesRows[i].tilesData[0];

            // Transform the respective tile in World Space to be in Sync with Map
            worldTilesRows[i].tilesData[0].Move(new Vector2Int(TilesPerRow, 0));
        }

        worldTilesRows = rows;
        
        return worldTilesRows;
    }

    /// <summary>
    /// Gets the current coordinates of the World Tile within the 3x3 matrix.
    /// </summary>
    public Vector2Int GetWorldTileCoordinates(Script_WorldTile worldTile)
    {
        for (int i = 0; i < worldTilesRows.Length; i++)
        {
            for (int j = 0; j < worldTilesRows[i].tilesData.Length; j++)
            {
                if (worldTilesRows[i].tilesData[j] == worldTile)
                {
                    return new Vector2Int(j, i);
                }
            }
        }

        return new Vector2Int(1, 1);
    }

    public void InitialState()
    {
        for (int i = 0; i < worldTilesRows.Length; i++)
        {
            for (int j = 0; j < worldTilesRows[i].tilesData.Length; j++)
            {
                worldTilesRows[i].tilesData[j].InitialState();
            }
        }   
    }
}
