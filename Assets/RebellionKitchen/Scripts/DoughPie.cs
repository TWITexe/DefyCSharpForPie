using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoughPie : MonoBehaviour
{
    public GameObject pan;                             // ????? ? ??????
    public GameObject tablePie;                        // ????-???????
    public GameObject test_layer;                      // ???? ? ??????
    public static bool isStartingTest = false;         // ????? ?? ?????
    public static bool attemptTest = false;            // ??????? ????? ??????????????
    public Sprite spritePan;                           // ????? ? ?????? ??????
    public Sprite spriteTablePie;                      // ???? ? ???????


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if ((isStartingTest == false) && (Input.GetKey(KeyCode.E)) && (formula.foundAllProduct && attemptTest == false))
            {
                attemptTest = true;
                isStartingTest = true;
                test_layer.SetActive(true);
                pan.GetComponent<SpriteRenderer>().sprite = spritePan;
                tablePie.GetComponent<SpriteRenderer>().sprite = spriteTablePie;
            }
        }
    }
}
