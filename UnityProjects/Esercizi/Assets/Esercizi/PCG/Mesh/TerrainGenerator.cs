using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AI.PCG
{
    public class TerrainGenerator : MonoBehaviour
    {
        MeshFilter meshFilter;
        Mesh mesh;

        void Start()
        {
            meshFilter = GetComponent<MeshFilter>();
            mesh = new Mesh();
            mesh.name = "Best Mesh";

            meshFilter.mesh = mesh;
            GetComponent<MeshCollider>().sharedMesh = mesh;
        }

        public int nX = 10;
        public int nY = 10;
        public float frequency, amplitude;
        public float quadSize = 1f;

        private List<Vector3> allVertices = new List<Vector3>();
        private List<int> allTriangles = new List<int>();
        private List<Vector2> allUvs = new List<Vector2>();

        void BuildQuad(Vector3 origin, float size, Vector3 normal)
        {
            int firstIndex = allVertices.Count;

            // Create the vertex list
            Vector3[] vertices = new Vector3[4];
            vertices[0] = origin + new Vector3(-size / 2, -size / 2, 0);
            vertices[1] = origin + new Vector3(-size / 2, size / 2, 0);
            vertices[2] = origin + new Vector3(size / 2, size / 2, 0);
            vertices[3] = origin + new Vector3(size / 2, -size / 2, 0);

            allVertices.AddRange(vertices);

            // Create the triangles list
            int[] triangles = new int[6];

            // Triangle 1
            triangles[0] = firstIndex + 0;
            triangles[1] = firstIndex + 1;
            triangles[2] = firstIndex + 2;

            // Triangle 2
            triangles[3] = firstIndex + 0;
            triangles[4] = firstIndex + 2;
            triangles[5] = firstIndex + 3;

            allTriangles.AddRange(triangles);

            // Create UV
            Vector2[] uvs = new Vector2[4];
            uvs[0] = new Vector2(0, 0);
            uvs[1] = new Vector2(0, 1);
            uvs[2] = new Vector2(1, 1);
            uvs[3] = new Vector2(1, 0);

            allUvs.AddRange(uvs);

        }

        void CompleteMesh()
        {
            mesh.vertices = allVertices.ToArray();
            mesh.triangles = allTriangles.ToArray();
            mesh.uv = allUvs.ToArray();

            mesh.RecalculateNormals();
            mesh.RecalculateBounds();
        }

        void ResetMesh()
        {
            allVertices.Clear();
            allTriangles.Clear();
            allUvs.Clear();
        }

        void Update()
        {
            ResetMesh();
            for (int x = 0; x < nX; x++)
            {
                for (int y = 0; y < nY; y++)
                {
                    Vector3 origin;
                    origin.x = x * quadSize;
                    origin.y = y * quadSize;
                    origin.z = amplitude * (Mathf.PerlinNoise(frequency * (x + 10 * Time.time) / (float)nX, frequency * y / (float)nY));
                    BuildQuad(origin, quadSize, Vector3.forward);
                }
            }

            CompleteMesh();
        }
    }
}