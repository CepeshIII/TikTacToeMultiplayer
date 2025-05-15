using Unity.Netcode;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NetworkManagerSceneInitializer : MonoBehaviour
{
    private void Start()
    {
        if (NetworkManager.Singleton != null)
            SceneManager.LoadScene(1);
    }
}
