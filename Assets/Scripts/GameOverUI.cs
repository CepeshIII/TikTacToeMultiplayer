using TMPro;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI resultTextMesh;
    [SerializeField] private Color winColor;
    [SerializeField] private Color loseColor;


    private void Start()
    {
        Hide();
        GameManager.Instance.OnGameWin += GameManager_OnGameWin;
    }

    private void GameManager_OnGameWin(object sender, GameManager.OnGameWinEventArgs e)
    {
        if (GameManager.Instance.GetLocalPlayerType() == e.winPlayerType)
        {
            resultTextMesh.text = "YOU WIN!";
            resultTextMesh.color = winColor;
        }
        else 
        {
            resultTextMesh.text = "YOU ARE DONE!";
            resultTextMesh.color = loseColor;
        }
        Show();
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
