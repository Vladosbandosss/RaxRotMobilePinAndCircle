using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollDetect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "CO")
        {
            Debug.Log("проигрыш");
            GameManger.instance.GameOver();
        }
    }
}
