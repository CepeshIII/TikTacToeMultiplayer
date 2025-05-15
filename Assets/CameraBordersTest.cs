using UnityEngine;

[ExecuteAlways]
public class CameraBordersTest : MonoBehaviour
{
    public float cameraSizeMin = 6.5f;
    public float cameraSizeMax = 12f;
    public float ratio;

    // Update is called once per frame
    void Update()
    {
        var pixelHeight = Camera.main.pixelHeight;
        var pixelWidth = Camera.main.pixelWidth;

        ratio = (pixelHeight / pixelWidth) - (1080f / 1920f);

        Camera.main.orthographicSize = Mathf.Lerp(cameraSizeMin, cameraSizeMax, ratio);
    }
}
