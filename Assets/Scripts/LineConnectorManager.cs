using UnityEngine;

public class LineConnectorManager : MonoBehaviour
{
    public DynamicLineConnector lineConnector;
    public Transform objectA;
    public Transform objectB;

    void Start()
    {
        lineConnector.pointA = objectA;
        lineConnector.pointB = objectB;
    }
}
