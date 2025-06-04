using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class DynamicLineConnector : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;

    private LineRenderer line;

    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.positionCount = 3;

        line.startWidth = 0.1f;
        line.endWidth = 0.1f;
        line.material = new Material(Shader.Find("Sprites/Default"));
        line.startColor = Color.cyan;
        line.endColor = Color.blue;
    }

    void Update()
    {
        if (pointA != null && pointB != null && pointC != null)
        {
            line.SetPosition(0, pointA.position);
            line.SetPosition(1, pointB.position);
            line.SetPosition(2, pointC.position);
        }
    }
}
