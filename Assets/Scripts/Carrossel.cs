using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrossel : MonoBehaviour {

    [SerializeField]
    private float velocity;

    private Vector3 position;

    private float tamImageReal;

    private void Awake()
    {
        //atribui a posição na variavel posição inicial
        position = transform.position;
        float tamImage = GetComponent<SpriteRenderer>().size.x;
        float escala = transform.localScale.x;
        tamImageReal = tamImage * escala;
    }
    // Update is called once per frame
    void Update () {
        float deslocamento = Mathf.Repeat(velocity * Time.time, tamImageReal); //retorna o tempo desde o play
        transform.position = position + Vector3.left * deslocamento;
	}
}
