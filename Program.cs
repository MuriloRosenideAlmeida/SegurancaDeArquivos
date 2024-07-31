using System;
using System.IO;
using System.Collections.Generic;

namespace SegurancaDeArquivos {
    internal class Program {
        static void Main(string[] args) {
            string path = @"C:\Users\Dan\OneDrive\Documents\faculdade";
            try {
                // Tipo inumeravel de string que cria um vetor de pastas contidas do caminho que especifiquei 
                IEnumerable <string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS");
                foreach (string folder in folders) {
                    Console.WriteLine(folder);
                }
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES");
                foreach (string file in files) {
                    Console.WriteLine(file);
                }
                Directory.CreateDirectory(path + "\\securityfolder");// Cria a pasta no diretorio que eu especificar
            }
            catch (IOException error) {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(error.Message);
            }
        }
    }
}