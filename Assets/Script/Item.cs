using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum Type { Ammo, Coin, Grenade, Heart, Weapon, Sword , Wand, Gun, Knife}
    public Type type;
    public int value;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * 30 * Time.deltaTime);
    }
}
