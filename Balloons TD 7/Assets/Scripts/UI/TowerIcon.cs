using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerIcon : MonoBehaviour
{

    public Tower tower;
    public Image icon;

    // Start is called before the first frame update
    void Start()
    {
        icon.sprite = tower.icon;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
