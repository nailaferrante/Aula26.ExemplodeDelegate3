using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SysLog
{
    public class Usuario
    {
        public string cadlogin { get; set; }
        public string cadsenha { get; set; }

        
        public string Cad(string cadLogin, string cadSenha)
            {
            StreamWriter swCadUsuario = new StreamWriter("cadUsuario.txt", true);
       
            swCadUsuario.WriteLine(cadLogin + ";" + encripSenha(cadSenha));
            swCadUsuario.Close();
            
            return "Cadastrado com sucesso";
            
        }
        static string encripSenha(string senha){    // método de encriptografar a senha, a idéia é pegar os bytes de cada caracter e jogar no array 
                                                    // (cada letra tem seu conjunto de bytes por isso array) para realizar o cálculo e devolver o hash.
                                                    // o resultado será um array de bytes que será convertido para string
            byte[] senhaOriginal;
            byte[] senhaModificada;
            MD5 md5; // MD é abstrato, classe abstrata não se constrói

            senhaOriginal = Encoding.Default.GetBytes(senha);   // Encoding.Default - padrão de caracter o sistema operacional GetByte - retira os bytes 
                                                                //e põe na posição, teremos um array de bytes de cada letra
            md5 = MD5.Create(); // Dentro da classe MD5 existe o método Create que cria a possibilidade de realizar a sua função de encriptografia.
            senhaModificada = md5.ComputeHash(senhaOriginal);
            return Convert.ToBase64String(senhaModificada); // ToBase64String - pega cada elemento dentro do array de bytes e converte para string
    }
}