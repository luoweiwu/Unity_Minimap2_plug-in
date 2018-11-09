using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    public float speed =4;

    private float timer = 0;
    private float dirx = 0;
    private float dirz = 0;
    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;
        if (timer > 4)
        {
            dirx = Random.Range(-1f, 1f);
            dirz = Random.Range(-1f, 1f);
            timer = 0;
        }
        transform.Translate(new Vector3(dirx, 0, dirz) * speed * Time.deltaTime);
    }
}
