using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{

   private void OnTriggerEnter2D(Collider2D obj)
    {
        if(obj.GetComponent<Bird>() != null)
        {
            GameController.Instance.Score();
        }
    }
}
