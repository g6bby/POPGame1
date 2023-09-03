using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI bubbleText;

    void Start()
    {
        bubbleText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateBubbleText(PlayerInventory playerInventory)
    {
        bubbleText.text = playerInventory.NumberOfBubbles.ToString();
    }
}
