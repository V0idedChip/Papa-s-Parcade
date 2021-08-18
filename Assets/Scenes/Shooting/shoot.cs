using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour
{
    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}