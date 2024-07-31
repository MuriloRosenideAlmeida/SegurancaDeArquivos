namespace SegurancaDeArquivos {
    internal class DirectoryMover {
        public static void MoveDirectory( string sourceDirectory, string destinationDirectory) {
            if (!Directory.Exists(destinationDirectory)) {
                Directory.CreateDirectory(destinationDirectory);
            }
            foreach (string file in Directory.GetFiles(sourceDirectory)) {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(destinationDirectory, fileName);
                File.Move(file, destFile);
            }
            foreach (string subdirectory in Directory.GetDirectories(sourceDirectory)) {
                string subdirectoryName = Path.GetFileName(subdirectory);
                string destinationSubdirectory = Path.Combine(destinationDirectory, subdirectoryName);
                Directory.Move(subdirectory, destinationSubdirectory);
              
            }
        }
    }
}
