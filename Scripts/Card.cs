using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Card : MonoBehaviour
{

    public CardData cardData = null;

    public Text titleText = null;
    public Text descriptionText = null;
    public Image damageImage = null;
    public Image costImage = null;
    public Image cardImage = null;
    public Image frameImage = null;
    public Image burnImage = null;

    public void initialise()
    {
        if (cardData==null) 
        {
            Debug.LogError("Card has no CardData!");
            return;
        }

        titleText.text = cardData.cardtitle;
        descriptionText.text = cardData.description;
        cardImage.sprite = cardData.cardImage;
        frameImage.sprite = cardData.frameImage;

    }
}
