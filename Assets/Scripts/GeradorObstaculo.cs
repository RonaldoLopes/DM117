using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculo : MonoBehaviour {

    /// <summary>
    /// Tempo de geração do obstaculo
    /// </summary>
    [SerializeField]
    private float timeGenerator;
    /// <summary>
    /// obstaculo a ser criado automaticamentes
    /// </summary>
    [SerializeField]
    private GameObject obstaculoPrefab;

    private float cronometro;

    private void Awake(){
        cronometro = timeGenerator;
    }
    // Update is called once per frame
    void Update () {
        cronometro -= Time.deltaTime;
        if(cronometro < 0) {
            GameObject.Instantiate(obstaculoPrefab, transform.position, Quaternion.identity);
            cronometro = timeGenerator;
        }
	}
}
