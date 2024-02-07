using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Items
{
    public string Name;
    public int ID;
    public GameObject model;

}
public class GameManagerStructs : MonoBehaviour
{
    public static GameManagerStructs Instance { get; private set; }
    [SerializeField]
    private List<Items> itemList = new List<Items>();

    public List<Items> ItemList
    {
        get { return itemList; }
    }

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
