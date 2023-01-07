using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerManager : MonoBehaviour
{
    private ConstructorManager _constructorManager;

    private TowerIcon _active;

    public Color highlight;
    
    // Start is called before the first frame update
    void Start()
    {
        _constructorManager = ConstructorManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TowerSelect(TowerIcon newTower)
    {
        Image background = newTower.gameObject.GetComponent<Image>();
        Color originalColor = background.color;
        print(newTower.tower.name);
        _constructorManager.ChangeActiveTower(newTower.tower);
        background.color = highlight;
        if (_active)
        {
            _active.GetComponent<Image>().color = originalColor;
        }
        _active = newTower;
    }
}
