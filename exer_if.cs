using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aluno : MonoBehaviour
{
    //Dados
    public string nomeAluno = "Asher Duarte";
    public int idadeAluno = 38;
    public bool isAprovado;
    //Media
    public float mediaA = 22.0F;
    public float mediaB = 25.0F;
    public float mediaC = 18.0F;
    public float mediaD = 12.0F;
    public float mediaAprovado = 80.0F;
    //Frequencia
    public int frequencia = 140;
    public int frequenciaNecessaria = 130;

    // Start is called before the first frame update
    void Start()
    {
        CalcMediaFinal();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //Calculo de media e frequencia
    public void CalcMediaFinal()
    {
        float mediaFinal = (mediaA + mediaB + mediaC + mediaD) / 4;

        if (mediaFinal >= mediaAprovado && frequencia >= frequenciaNecessaria)
        {
            isAprovado = true;
            print("O aluno " + nomeAluno
                + " foi aprovado com média: " + mediaFinal
                + " frequencia de " + frequencia + "%");
        }
        else
        {
            isAprovado = false;
            print("O aluno " + nomeAluno + " foi reprovado");
        }
    }
}
