using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ConstructorManager : MonoBehaviour
{
    public Grid grid;
    public Transform cursor;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3Int cellPosition = grid.WorldToCell(mousePos);
        cursor.position = grid.CellToWorld(cellPosition) + new Vector3(0,grid.cellSize.y/2,0);
        print(mousePos);
    }
    
    
}
