using System;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public event EventHandler<OnClickedOnGridPositionEventArgs> OnClickedOnGridPosition;
    public class OnClickedOnGridPositionEventArgs: EventArgs
    {
        public int x;
        public int y;
    } 

    public void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            throw new System.Exception("Game has more than one GameManager Instance");
        }
        Instance = this;
    }

    public void ClickedOnGridPosition(int x, int y)
    {
        OnClickedOnGridPosition?.Invoke(this, new OnClickedOnGridPositionEventArgs 
        { 
            x = x, 
            y = y
        });
        Debug.Log($"Clicked on grid position: (x, y)");
    }

}
