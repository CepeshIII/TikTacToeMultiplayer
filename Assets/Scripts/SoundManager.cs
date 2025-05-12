using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private Transform placeSFXPrefab;
    [SerializeField] private Transform winSfxPrefab;
    [SerializeField] private Transform loseSfxPrefab;

    private void Start()
    {
        GameManager.Instance.OnPlacedObject += GameManager_OnPlacedObject;
        GameManager.Instance.OnGameWin += GameManager_OnGameWin;
    }

    private void GameManager_OnGameWin(object sender, GameManager.OnGameWinEventArgs e)
    {
        if (e.winPlayerType == GameManager.Instance.GetLocalPlayerType()) 
        { 
            PlaySfx(winSfxPrefab);
        }
        else
        {
            PlaySfx(loseSfxPrefab);
        }
    }

    private void GameManager_OnPlacedObject(object sender, System.EventArgs e)
    {
        PlaySfx(placeSFXPrefab);
    }

    private void PlaySfx(Transform sfxPrefab)
    {
        var sfxTransform = Instantiate(sfxPrefab);
        Destroy(sfxTransform.gameObject, 5f);
    }
}
