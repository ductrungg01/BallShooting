using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject bullet;

    MC _mc;

    // Start is called before the first frame update
    void Start()
    {
        _mc = FindObjectOfType<MC>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnBullet()
    {
        if (bullet)
        {
            Vector3 pos = _mc.transform.position;
            Quaternion rotation = _mc.transform.rotation;

            Instantiate(bullet, pos, rotation);
        }
    }
}
