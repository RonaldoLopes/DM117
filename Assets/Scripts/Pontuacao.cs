using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour {

    [SerializeField]
    private Text txtPontuacao;
    private int points;
    private AudioSource audioPoint;

    private void Awake(){
        audioPoint = GetComponent<AudioSource>();
    }

    /// <summary>
    /// Adiciona os pontos obtidos
    /// </summary>
	public void AddPoint(){

        points++;
        txtPontuacao.text = points.ToString();
        audioPoint.Play();

    }
}
