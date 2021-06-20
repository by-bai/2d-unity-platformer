using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Misobee")
        {
            collision.gameObject.transform.SetParent(transform); 
            //set player as child of moving platform
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Misobee")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }

}
