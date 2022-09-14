using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerAddLongPaddle : MonoBehaviour
{
    public Transform left_paddle;
    public Transform right_paddle;
    public Collider2D ball;
    public PowerUpManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            StartCoroutine(manager.ScaleOnCertainTime(left_paddle, gameObject));
        }
    }

}
