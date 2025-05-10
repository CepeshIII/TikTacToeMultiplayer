using UnityEngine;

public class Singleton<T>: MonoBehaviour where T: MonoBehaviour
{
    public static T Instance { get; private set; }

    private void OnEnable()
    {
        if (Instance != null)
        {
            Destroy(this);
        }

        Instance = this as T;
    }
}
