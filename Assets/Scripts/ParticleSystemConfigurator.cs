using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class ParticleSystemConfigurator : MonoBehaviour
{
    public Color particleColor = Color.red;
    public float startSize = 0.5f;
    public float startSpeed = 2f;
    public Material newParticleMaterial;

    private ParticleSystem particle;
    private ParticleSystem.MainModule mainModule;
    private ParticleSystemRenderer psRenderer;

    void Start()
    {
        particle = GetComponent<ParticleSystem>();
        mainModule = particle.main;
        psRenderer = GetComponent<ParticleSystemRenderer>();

        ApplySettings();

        if (newParticleMaterial != null)
        {
            Debug.Log("Material asignado al ParticleSystem: " + newParticleMaterial.name);
            if (newParticleMaterial.mainTexture == null)
                Debug.LogWarning("¡El material no tiene textura asignada!");
        }

        Debug.Log("Tamaño inicial de partículas: " + mainModule.startSize.constant);
    }
    void Update()
    {
        var main = particle.main;
        if (main.startSize.constant != startSize)
        {
            ParticleSystem.MainModule m = particle.main;
            m.startSize = startSize;
        }
    }
    public void ApplySettings()
    {
        mainModule.startColor = particleColor;

        mainModule.startSize = startSize;

        mainModule.startSpeed = startSpeed;

        if (newParticleMaterial != null)
        {
            psRenderer.material = newParticleMaterial;
        }
        particle.Play();
    }
}
