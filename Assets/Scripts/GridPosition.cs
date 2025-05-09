using System;
using UnityEngine;

public class GridPosition : MonoBehaviour
{
    [SerializeField] private Vector2Int m_Position;

    private void OnMouseDown()
    {
        GameManager.Instance.ClickedOnGridPosition(m_Position.x, m_Position.y);
        Debug.Log("I have been clicked");
    }
}
