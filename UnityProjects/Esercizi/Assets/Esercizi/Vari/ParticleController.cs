using UnityEngine;
using System.Collections;

public class ParticleController : MonoBehaviour {

    public ParticleSystem ps;


	void Update ()
    {
    ps.startSpeed = 10 * (Mathf.Sin(Time.time / Mathf.PI) + 1f);

        ParticleSystem.Particle[] myParticles = new ParticleSystem.Particle[ps.particleCount];
        ps.GetParticles(myParticles);
        for (int i = 0; i < myParticles.Length; i++)
        {
            myParticles[i].startColor = new Color32(255, (byte)(Mathf.Sin(Time.time*10)*255),0,255);
        }
        ps.SetParticles(myParticles, ps.particleCount);
	}
}
