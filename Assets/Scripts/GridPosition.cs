using System;
using UnityEngine;

public class GridPosition : MonoBehaviour
{
    [SerializeField] private Vector2Int m_Position;

    private void OnMouseDown()
    {
        GameManager.Instance.ClickedOnGridPositionRpc(m_Position.x, m_Position.y, GameManager.Instance.GetLocalPlayerType());
        Debug.Log("I have been clicked");
    }
}
