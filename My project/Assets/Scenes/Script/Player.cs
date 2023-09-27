using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    {
         Debug.Log("Start");
         float h = Input.GetAxis("Horizontal"); //-1 esquerda, 0 nada, 1 direita
         float v = Input.GetAxis("Vertical"); // -1 pra tras, 0 nada, 1 pra cima 

         Vector3 direcao = new Vector3(h, 0, v);
    }
}

