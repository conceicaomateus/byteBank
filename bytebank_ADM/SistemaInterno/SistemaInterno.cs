﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (!usuarioAutenticado)
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }

            Console.WriteLine($"Boas vindas ao nosso sistema.");
            return true;
        }
    }
}
