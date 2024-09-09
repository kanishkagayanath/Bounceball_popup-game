using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
