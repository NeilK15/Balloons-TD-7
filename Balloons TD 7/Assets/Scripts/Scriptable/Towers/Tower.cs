using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Towers/Sample", fileName = "Sample")]
public class Tower : ScriptableObject
{

    public new string name;
    
    public Sprite icon;
    public float cost;
    public float damage;
    public GameObject tower;
    
}
