using UnityEngine;
using System.Collections;

namespace AI.PCG
{
    public class TextureGenerator : MonoBehaviour
    {
        public int width = 128;
        public int height = 128;

        private Texture2D texture;


        void Start()
        {
            texture = new Texture2D(width, height, TextureFormat.RGBA32, false);
            texture.filterMode = FilterMode.Point;
            GetComponent<MeshRenderer>().material.mainTexture = texture;

            /*for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color color;
                    float v = Mathf.PerlinNoise(x / 10f, y / 10f); 
                    color.r = v;
                    color.g = v;
                    color.b = v;
                    color.a = 1;
                    texture.SetPixel(x, y, color);
                }
            }

            texture.Apply();*/

        }

        void Update()
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color color;
                    float v = Random.value;
                    color.r = v;
                    color.g = v;
                    color.b = v;
                    color.a = 1;
                    texture.SetPixel(x, y, color);
                }
            }

            texture.Apply();
        }
    }
}