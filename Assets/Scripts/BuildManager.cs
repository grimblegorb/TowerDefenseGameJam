using UnityEngine;

public class BuildManager : MonoBehaviour
{
    //Stores reference to its self 
    public static BuildManager instance;

    void Awake()
    {
        //Make sure that this is the only build manager that can also be referenced
        instance = this; 
    }
    
    public GameObject standardTowerPrefab;

    void Start()
    {
        towerToBuild = standardTowerPrefab;
    }
    
    private GameObject towerToBuild;

    public GameObject GetTowerTobuild ()
    {
        return towerToBuild;
    }
}
