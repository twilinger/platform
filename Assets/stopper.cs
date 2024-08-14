using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopper : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
            if (collision.tag == "Player")
            {
                gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            }
        }
    }



