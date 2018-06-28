using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour {

    [SerializeField]
    private float velocity  = 0.1f;
    private Vector3 posAviao;
    private bool pontuei;
    private Pontuacao pontos;

    private void Awake(){
        transform.Translate(Vector3.up * Random.Range(-1.4f, 1.4f));
    }

    private void Start(){
        posAviao = GameObject.FindObjectOfType<Aviao>().transform.position;//pega a posição do avião
        pontos = GameObject.FindObjectOfType<Pontuacao>();
    }
    // Update is called once per frame
    void Update () {
        this.transform.Translate(Vector3.left * velocity * Time.deltaTime);
        //se posição atual do obstaculo for menor que a do aviao
        if(!pontuei && transform.position.x < posAviao.x) {
            pontuei = true;
            pontos.AddPoint();
        }
	}

    private void OnTriggerEnter2D(Collider2D collision){
        Destroy();
    }

    /// <summary>
    /// Destroi o gameobject após detectar colisão do obstaculo
    /// </summary>
    private void Destroy(){
        GameObject.Destroy(gameObject);
    }
}
