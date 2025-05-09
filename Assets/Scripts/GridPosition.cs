using System;
using UnityEngine;

public class GridPosition : MonoBehaviour
{
    [SerializeField] private Vector2 m_Position;

    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown by position: " + m_Position);
    }
}
