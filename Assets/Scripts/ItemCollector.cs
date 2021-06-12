using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ItemCollector : MonoBehaviour
{
    private int strawberries = 0;

    [SerializeField] private Text strawberriesText; 

    private void OnTriggerEnter2D(Collider2D collision)

    {
        //use this because set Box Collider of Strawberry to IsTrigger
        //google : how to collect items in Unity

        if (collision.gameObject.CompareTag("Strawberry"))
        {
            Destroy(collision.gameObject);
            strawberries++;
            strawberriesText.text = "Strawberries: " + strawberries; 

        }
    }
}
