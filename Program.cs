using System;
using System.Security.Cryptography;
using System.Text;

namespace SysLog
{
    class Program
    {
        static void Main(string[] args)
        {         
            string opcao = "";
            do{           
                Console.WriteLine("Menu do SysLog");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Login");
                Console.WriteLine("3 - Logout");
                Console.WriteLine("9 - Sair");

                switch(opcao){
                    case "1":
                    Console.WriteLine("Informe o login para o novo usuário: ");
                    string cadlogin = Console.ReadLine();
                    Console.WriteLine("Informe a senha para o novo usuário: ");
                    string cadsenha = Console.ReadLine();
                    
                    Usuario cadastrar = new Usuario();
                    cadastrar.Cad(cadlogin,cadsenha);
                    

                    break;
                    case "2":
                    break;
                    case "3":
                    break;
                    case "9":
                    break;
                    default:
                    break;
                }
            

            }while(opcao != "9");

        
        }
        

        }
    }
}
