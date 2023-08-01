﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }



        public abstract double GetBonificacao();
        //{
            
          //  return this.Salario * 0.10;
        //}

        public Funcionario(string Cpf, double salario)
        {
            this.Salario = salario;
            this.Cpf= Cpf;
            TotalDeFuncionarios++;
            //Console.WriteLine("Criando um funcionário." );
        }
        public abstract void AumentarSalario();
        //{
        //  this.Salario *= 1.10;
        //}

       
    }
}
