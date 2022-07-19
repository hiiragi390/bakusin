using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeFade : MonoBehaviour
{
    float fade = 0.5f;
    float time;
    SpriteRenderer sp;
    // Start is called before the first frame update
    void Start()
    {
        sp = this.gameObject.GetComponent<SpriteRenderer>();
        time = fade;
    }

    // Update is called once per frame
    void Update()
    {

        time -= Time.deltaTime;
        float a = time / fade;
        var col = sp.color;
        col.a = a;
        sp.color = col;
    }
}
