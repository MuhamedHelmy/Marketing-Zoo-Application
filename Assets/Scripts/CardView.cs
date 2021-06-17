using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    public Text Title;
    public Text Description;
    public Text Smalldic;
    public Image icon;
    public CardModel[] animals;


    public void viewCard(int index)
    {
        Title.text = animals[index].title;
        Description.text = animals[index].description;
        Smalldic.text = animals[index].smalldesc;
        icon.sprite = animals[index].icon;
    }


}
