using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Configuration;


namespace CriptografiaMD5
{

   public class cifrawebconfig
    {

        // Proteja a seção connectionStrings.
       public static void ProtegerConfiguration()
        {
            // Obter o arquivo de configuração do aplicativo.
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Define o nome do provedor de RSA.
            string provider = "RsaProtectedConfigurationProvider";


            ConfigurationSection connStrings = config.ConnectionStrings;

            if (connStrings != null)
            {
                if (!connStrings.SectionInformation.IsProtected)
                {
                    if (!connStrings.ElementInformation.IsLocked)
                    {
                        // Proteja a seção.
                        connStrings.SectionInformation.ProtectSection(provider);

                        connStrings.SectionInformation.ForceSave = true;
                        config.Save(ConfigurationSaveMode.Full);

                        Console.WriteLine("Seção {0} está agora protegida por {1}",
                            connStrings.SectionInformation.Name,
                            connStrings.SectionInformation.ProtectionProvider.Name);
                    }
                    else
                        Console.WriteLine(
                             "Não é possível proteger, section {0} está bloqueado",
                             connStrings.SectionInformation.Name);
                }
                else
                    Console.WriteLine(
                        "Seção {0} já está protegido por {1}",
                        connStrings.SectionInformation.Name,
                        connStrings.SectionInformation.ProtectionProvider.Name);
            }
            else
                Console.WriteLine("Não é possível obter a seção {0}",
                    connStrings.SectionInformation.Name);

        }



        // Desproteger a seção connectionStrings. 
       public static void DesprotegerConfiguration()
        {

            // Obter o arquivo de configuração do aplicativo.
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Obter seção para desproteger.
            ConfigurationSection connStrings = config.ConnectionStrings;

            if (connStrings != null)
            {
                if (connStrings.SectionInformation.IsProtected)
                {
                    if (!connStrings.ElementInformation.IsLocked)
                    {
                        // Desproteger a seção.
                        connStrings.SectionInformation.UnprotectSection();

                        connStrings.SectionInformation.ForceSave = true;
                        config.Save(ConfigurationSaveMode.Full);

                        Console.WriteLine("Seção {0} é agora desprotegido.",
                            connStrings.SectionInformation.Name);

                    }
                    else
                        Console.WriteLine(
                             "Não pode desproteger, section {0} está bloqueado",
                             connStrings.SectionInformation.Name);
                }
                else
                    Console.WriteLine(
                        "Seção {0} já está desprotegida.",
                        connStrings.SectionInformation.Name);

            }
            else
                Console.WriteLine("Não é possível obter a seção {0}",
                    connStrings.SectionInformation.Name);

        }


    }


}