using UnityEngine;
using UnityEngine.UI;

public class PackageAlphaThreshold : MonoBehaviour
{
    private Image _packageImage;

    private void Awake()
    {
        _packageImage = GetComponent<Image>();
        _packageImage.alphaHitTestMinimumThreshold = 0.001f;
    }
}
