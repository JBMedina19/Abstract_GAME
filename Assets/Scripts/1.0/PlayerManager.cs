using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class PlayerManager : MonoBehaviour
{
    GameManagerStructs gm;
    [ReadOnlyInspector] public string WeaponEqquipedName;
    [ReadOnlyInspector] public GameObject EqquipedItem;
    public Transform hand;
    public Vector3 handOffsetPos;
    public Vector3 handOffsetRot;
    public int EquipmentID;

    int previousID;
    bool isCreated;
    bool destroyPrev;

    private WeaponAbilities currentWeapon;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
        destroyPrev = false;
        isCreated = true;
        gm = GameManagerStructs.Instance;
        previousID = EquipmentID;
    }

    // Update is called once per frame
    void Update()
    {
        WeaponsChecker();
        WeaponModelUpdate();
        Attack();
        EquipWeapon(EqquipedItem.GetComponent<WeaponAbilities>());
    }
    public void EquipWeapon(WeaponAbilities weapon)
    {
        currentWeapon = weapon;
    }
    public void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            currentWeapon.Ultimate();
            anim.SetTrigger("Attack");
        }
    }
    public void WeaponsChecker()
    {

        if (previousID != EquipmentID)
        {
            previousID = EquipmentID;
            isCreated = true;
            destroyPrev = true;
        }
        WeaponEqquipedName = gm.ItemList[EquipmentID].Name;
        EqquipedItem = gm.ItemList[EquipmentID].model;
    }

 

    public void WeaponModelUpdate()
    {
        if (isCreated)
        {
            GameObject weapon = Instantiate(EqquipedItem, hand.transform);
            weapon.transform.SetParent(hand);
            isCreated = false;
            if (destroyPrev)
            {
                var prevWeapon = hand.transform.GetChild(0);
                Destroy(prevWeapon.gameObject);
                destroyPrev = false;
            }
        }

    }
}
