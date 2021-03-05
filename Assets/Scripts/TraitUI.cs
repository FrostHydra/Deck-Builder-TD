using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(Trait))]
public class TraitUI : Editor
{
    public override void OnInspectorGUI()
    {
        Trait traits = (Trait)target;
        if (traits.trait.Length != traits.traitName.Length)
        {
            traits.SetTraitLength();
        }
        foreach (int trait in traits.traitName)
        {
            //Create a checkbox for each trait
            traits.trait[trait] = EditorGUILayout.Toggle(traits.traitName[trait].ToString(), traits.trait[trait]);
        }
    }
}
