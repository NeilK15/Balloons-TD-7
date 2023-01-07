using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ConstructorManager : MonoBehaviour
{
    public Grid grid;
    public Transform cursor;
    public Tilemap groundTilemap;
    public Tower[] tiles;

    private Tower _activeTower;
    private Sprite _defaultCursor;

    public static ConstructorManager instance;

    #region Singleton
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Huh, multiple Inventories???");
            return;
        }
        instance = this;
    }

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        ChangeActiveTower(null);
        _defaultCursor = cursor.GetComponent<SpriteRenderer>()?.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        VisualizeTower();
    }

    public void ChangeActiveTower(Tower newTower)
    {
        _activeTower = newTower;
        if (_activeTower != null)
        {
            SpriteRenderer cursorSpriteRenderer = cursor.GetComponent<SpriteRenderer>();
            cursor.gameObject.SetActive(true);
            if (cursorSpriteRenderer != null)
            {
                cursorSpriteRenderer.sprite = Instantiate(_activeTower.tower.GetComponent<SpriteRenderer>()?.sprite);
                cursorSpriteRenderer.color = new Color(1f, 1f, 1f, 0.5f);
            }
        }
    }

    void VisualizeTower()
    {
        if (_activeTower != null)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int cellPosition = grid.WorldToCell(mousePos);
            Vector3 tilePosition = grid.CellToWorld(cellPosition) + new Vector3(0, grid.cellSize.y / 2, 0);

            cursor.position = tilePosition;



            if (Input.GetMouseButton(1))
            {
                if (groundTilemap.GetTile(cellPosition) != null)
                    Instantiate(tiles[0].tower, cursor.position, Quaternion.identity);

            }
        }
    }
    
}
