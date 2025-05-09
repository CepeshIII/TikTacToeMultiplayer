using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

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
        Debug.Log($"Clicked on grid position: (x, y)");
    }

}
