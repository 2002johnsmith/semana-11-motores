using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class MaterialVisualizer : MonoBehaviour
{
    public MaterialData materialData;
    private Material runtimeMaterial;

    void Start()
    {
        if (materialData != null)
        {
            materialData.OnMaterialChanged += UpdateMaterial;
            runtimeMaterial = GetComponent<Renderer>().material;
            UpdateMaterial();
        }
    }

    void OnDestroy()
    {
        if (materialData != null)
            materialData.OnMaterialChanged -= UpdateMaterial;
    }

    void UpdateMaterial()
    {
        if (runtimeMaterial != null)
        {
            runtimeMaterial.color = materialData.color;
            runtimeMaterial.SetColor("_EmissionColor", materialData.color * materialData.emissionIntensity);
        }
    }
}
