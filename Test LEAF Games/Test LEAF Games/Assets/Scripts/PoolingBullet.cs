using UnityEngine;
using System.Collections;

public class PoolingBullet : MonoBehaviour {

	private void OnEnable()
    {
        Invoke("DisableBullet", 1f);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void DisableBullet()
    {
        this.gameObject.SetActive(false);
    }
}
