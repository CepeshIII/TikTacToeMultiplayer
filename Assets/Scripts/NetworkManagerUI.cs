using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetworkManagerUI : MonoBehaviour
{
    [SerializeField] private Button startHostButton;
    [SerializeField] private Button startClientButton;

    private void Awake()
    {
        startClientButton.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartClient();
            Hide();
        });
        startHostButton.onClick.AddListener(() => 
        { 
            NetworkManager.Singleton.StartHost();
            Hide();
        });
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
