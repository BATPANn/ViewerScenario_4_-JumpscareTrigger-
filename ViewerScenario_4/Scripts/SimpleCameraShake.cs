using UnityEngine;

public class SimpleCameraShake : MonoBehaviour
{
    private Vector3 originalPos;
    private float shakeDuration = 0f;
    private float shakeAmount = 0.1f;
    private float decreaseFactor = 1.5f;

    void OnEnable()
    {
        originalPos = transform.localPosition;
    }

    void Update()
    {
        if (shakeDuration > 0)
        {
            transform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;
            shakeDuration -= Time.deltaTime * decreaseFactor;
        }
        else
        {
            shakeDuration = 0f;
            transform.localPosition = originalPos;
        }
    }

    // Call this method to trigger the shake
    public void Shake(float duration = 3f, float amount = 0.1f)
    {
        shakeDuration = duration;
        shakeAmount = amount;
    }
}
