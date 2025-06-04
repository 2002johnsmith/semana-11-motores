using UnityEngine;
using System;

[CreateAssetMenu(fileName = "NewMaterialData", menuName = "Custom/Material Data")]
public class MaterialData : ScriptableObject
{
    public Color color = Color.yellow;
    [Range(0f, 5f)]
    public float emissionIntensity = 1f;

    public event Action OnMaterialChanged;

    public void SetColor(Color newColor)
    {
        color = newColor;
        OnMaterialChanged?.Invoke();
    }

    public void SetEmission(float intensity)
    {
        emissionIntensity = intensity;
        OnMaterialChanged?.Invoke();
    }
}
