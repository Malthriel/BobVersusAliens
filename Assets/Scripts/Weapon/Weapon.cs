﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public interface IWeapon
{
    
    void Shoot(Vector3 mousePosition);

}

public enum FirstSlotWeapons
{
    Pistol
}

public enum SecondSlotWeapons
{
    Rifle
}
public enum ThirdSlotWeapons
{

}