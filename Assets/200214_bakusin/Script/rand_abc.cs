using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rand_abc : MonoBehaviour
{
    public List<char> abc;
    string char_list = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    char p;
    int n = 0;
    public static int num =  5;
    // Start is called before the first frame update
    void Start()
    {
        num = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (n < 1)
        {
            for (int i = 0; i < 50; i++)
            {
                p = char_list[Random.Range(0, char_list.Length)];
                abc.Add(p);
            }

            n++;
        }
    }
}
