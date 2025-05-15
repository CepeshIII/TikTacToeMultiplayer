using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Button quitButton;
    [SerializeField] private GameObject circleArrowGameObject;
    [SerializeField] private GameObject crossArrowGameObject;
    [SerializeField] private GameObject circleYouTextGameObject;
    [SerializeField] private GameObject crossYouTextGameObject;
    [SerializeField] private TextMeshProUGUI playerCircleScoreTextMesh;
    [SerializeField] private TextMeshProUGUI playerCrossScoreTextMesh;


    private void Awake()
    {
        quitButton.onClick.AddListener(() =>
        {
            GameManager.Instance.QuitFromGame();
        });

        quitButton.gameObject.SetActive(false);
        circleArrowGameObject.SetActive(false);
        crossArrowGameObject.SetActive(false);
        circleYouTextGameObject.SetActive(false);
        crossYouTextGameObject.SetActive(false);

        playerCircleScoreTextMesh.text = "";
        playerCrossScoreTextMesh.text = "";
    }

    private void Start()
    {
        GameManager.Instance.OnGameStarted += GameManager_OnGameStarted;
        GameManager.Instance.OnCurrentPlayablePlayerTypeChange += GameManager_OnCurrentPlayablePlayerTypeChange;
        GameManager.Instance.OnScoreChanged += GameManager_OnScoreChanged;
    }

    private void GameManager_OnScoreChanged(object sender, EventArgs e)
    {
        GameManager.Instance.GetScores(out var playerCrossScore, out var playerCircleScore);
        
        playerCircleScoreTextMesh.text = playerCircleScore.ToString();
        playerCrossScoreTextMesh.text = playerCrossScore.ToString();
    }

    private void GameManager_OnCurrentPlayablePlayerTypeChange(object sender, EventArgs e)
    {
        UpdateCurrentArrow();
    }

    private void GameManager_OnGameStarted(object sender, System.EventArgs e)
    {
        if (GameManager.Instance.GetLocalPlayerType() == GameManager.PlayerType.Cross)
        {
            crossYouTextGameObject.SetActive(true);
        }
        else
        {
            circleYouTextGameObject.SetActive(true);
        }

        playerCircleScoreTextMesh.text = "0";
        playerCrossScoreTextMesh.text = "0";

        UpdateCurrentArrow();
        quitButton.gameObject.SetActive(true);
    }

    private void UpdateCurrentArrow()
    {
        if(GameManager.Instance.GetCurrentPlayablePlayerType() == GameManager.PlayerType.Cross)
        {
            crossArrowGameObject.SetActive(true);
            circleArrowGameObject.SetActive(false);
        }
        else
        {
            circleArrowGameObject.SetActive(true);
            crossArrowGameObject.SetActive(false);
        }
    }
}
