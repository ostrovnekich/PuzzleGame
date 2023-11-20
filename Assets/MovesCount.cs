using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovesCount : MonoBehaviour
{
    public int moves = 0;

    public Text text;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            StartCoroutine(Delay());
            //moves++;
            //text.text = moves.ToString();
            //Debug.Log(moves);
        }
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.45f);
        moves++;
        text.text = moves.ToString();
        Debug.Log(moves);
        //yield return new WaitForSeconds(1);
    }
}
