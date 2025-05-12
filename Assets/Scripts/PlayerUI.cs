using System;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private GameObject circleArrowGameObject;
    [SerializeField] private GameObject crossArrowGameObject;
    [SerializeField] private GameObject circleYouTextGameObject;
    [SerializeField] private GameObject crossYouTextGameObject;


    private void Awake()
    {
        circleArrowGameObject.SetActive(false);
        crossArrowGameObject.SetActive(false);
        circleYouTextGameObject.SetActive(false);
        crossYouTextGameObject.SetActive(false);
    }

    private void Start()
    {
        GameManager.Instance.OnGameStarted += GameManager_OnGameStarted;
        GameManager.Instance.OnCurrentPlayablePlayerTypeChange += GameManager_OnCurrentPlayablePlayerTypeChange;
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

        UpdateCurrentArrow();
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
