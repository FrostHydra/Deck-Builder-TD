using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trait : MonoBehaviour
{
    public enum Traits
    {
        Ground = 0,
        Flying = 1,
        Immune = 2,
        Stealth = 3,
        Boss = 4
    }


    public Traits[] traitName = { Traits.Ground, Traits.Flying, Traits.Immune, Traits.Stealth, Traits.Boss };
    public bool[] trait = new bool[20];

    public bool GetTrait(Traits traitName)
    {
        return trait[(int)traitName];
    }
    public void SetTrait(int id, bool value)
    {
        trait[id] = value;
    }

    public void SetTraitLength()
    {
        trait = new bool[traitName.Length];
    }
}
