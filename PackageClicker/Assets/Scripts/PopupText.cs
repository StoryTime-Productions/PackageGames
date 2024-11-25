using TMPro;
using UnityEngine;

public class PopupText : MonoBehaviour
{
    [SerializeField] private float _startingVelocity = 750f;
    [SerializeField] private float _velocityDecayRate = 1500f;
    [SerializeField] private float _timeBeforeFadeStarts = 0.6f;
    [SerializeField] private float _fadeSpeed = 3f;

    private TextMeshProUGUI _clickAmountText;

    private Vector2 _currentVelocity;

    private Color _startColor;
    private float _timer;
    private float _textAlpha;

    private void OnEnable()
    {
        _clickAmountText = GetComponent<TextMeshProUGUI>();

        Color newColor = _clickAmountText.color;
        newColor.a = 1f;
        _clickAmountText.color = newColor;

        _startColor = newColor;
        _timer = 0f;
        _textAlpha = 1f;
    }

    public static PopupText Create(double amount)
    {
        GameObject popupObj = ObjectPoolManager.SpawnObject(PackageManager.instance.PackageTextPopup, PackageManager.instance.MainGameCanvas.transform);
        popupObj.transform.position = PackageManager.instance.MainGameCanvas.transform.position;

        PopupText packagePopup = popupObj.GetComponent<PopupText>();
        packagePopup.Init(amount);

        return packagePopup;
    }

    public void Init(double amount)
    {
        _clickAmountText.text = "+" + amount.ToString("0");

        float randomX = Random.Range(-300f, 300f);
        _currentVelocity = new Vector2(randomX, _startingVelocity);
    }

    private void Update()
    {
        //move
        _currentVelocity.y -= Time.deltaTime * _velocityDecayRate;
        transform.Translate(_currentVelocity * Time.deltaTime);

        //change color
        _timer += Time.deltaTime;
        if (_timer > _timeBeforeFadeStarts)
        {
            _textAlpha -= Time.deltaTime * _fadeSpeed;
            _startColor.a = _textAlpha;
            _clickAmountText.color = _startColor;

            if (_textAlpha <= 0f)
            {
                ObjectPoolManager.ReturnObjectToPool(gameObject);
            }
        }
    }
}
