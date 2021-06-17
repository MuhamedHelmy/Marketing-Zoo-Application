using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "menu")]
public class CardModel : ScriptableObject
{

    public string title;
    public string description;
    public string smalldesc;
    public Sprite icon;
}
