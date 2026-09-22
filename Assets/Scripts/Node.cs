using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;
    public Quaternion rotationOffset;

    private GameObject tower;

    private Renderer rend;
    private Color startColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseDown()
    {
        if(tower != null)
        {
            Debug.Log("Can't Build there"); //Display on console for now
            return;
        }
        //Summon a tower
        GameObject towerToBuild = BuildManager.instance.GetTowerTobuild();
        tower = (GameObject)Instantiate(towerToBuild,transform.position + positionOffset,transform.rotation * rotationOffset);


    }
    
    void OnMouseEnter()
    {
        rend.material.color = hoverColor; 
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
