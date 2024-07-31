using System;
using System.IO;
using System.Collections.Generic;

namespace SegurancaDeArquivos {
    internal class Program {
        static void Main(string[] args) {
            string path = @"C:\Users\Dan\OneDrive\Documents\server";
            string newFolderPath = Path.Combine(path, "securityfolder");
            try {
                Directory.CreateDirectory(newFolderPath);
                DirectoryMover.MoveDirectory(path, newFolderPath);
                Console.WriteLine($"Pastas e arquivos movidos/copiedos para {newFolderPath}");
            }
            catch (IOException error) {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(error.Message);
            } 
            catch (UnauthorizedAccessException error) {
                Console.WriteLine("Access denied");
                Console.WriteLine(error.Message);
            } catch (Exception error) {
                Console.WriteLine("An unexpected error occurred");
                Console.WriteLine(error.Message);
            }
        }
    }
}