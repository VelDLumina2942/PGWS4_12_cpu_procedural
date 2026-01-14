using UnityEngine;

public class PolygonMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3[] vertices =
        {
            new Vector3(1.0f,0.0f,0.0f),
            new Vector3(0.0f,1.0f,0.0f),
            new Vector3(0.0f,0.0f,1.0f),
        };
        Color[] color = { Color.red, Color.green, Color.blue };
        int[] triangles = { 0, 1, 2 };

        Mesh Mesh = GetComponent<MeshFilter>().mesh;

        Mesh.Clear();
        Mesh.vertices = vertices;
        Mesh.colors = color;
        Mesh.triangles = triangles;

        Mesh.RecalculateBounds();
        Mesh.RecalculateNormals();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
