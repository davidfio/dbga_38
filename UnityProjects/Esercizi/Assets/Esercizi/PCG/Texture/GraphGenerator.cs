using UnityEngine;
using System.Collections;

namespace AI.PCG
{
    public class GraphGenerator : MonoBehaviour
    {
        Vector3 startPos;
        void Start()
        {
            startPos = transform.position;
        }
        public float frequency = 1f;
        public float phase = 0f;
        public float amplitude = 1f;

        void Update()
        {
            Debug.Log(Mathf.PerlinNoise(Time.time, 0));
            this.transform.position = new Vector3(Time.time, amplitude * Mathf.PerlinNoise(frequency * Time.time + phase, 0), 0) + startPos;
            //this.transform.position = new Vector3(Time.time, Mathf.Sin(frequency* Time.time + phase), 0) + startPos;
        }
    }
}