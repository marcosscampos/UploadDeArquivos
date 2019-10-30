using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Site_TP.Servicos_Externos;

namespace TesteUnitário {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void ConnectToAzure() {

            //Vai buscar pela pasta que configurei para fazer o upload da foto
            var documents = Environment.SpecialFolder.MyDocuments;
            string localPath = Environment.GetFolderPath(documents);

            //procurar pelo nome da foto
            var localFileName = "universe.jpg";
            string sourceFile = Path.Combine(localPath, localFileName);

            var reader = File.OpenRead(sourceFile);

            ServidorDeArquivos servidorDeArquivos = new ServidorDeArquivos();
            servidorDeArquivos.UploadDeArquivo(reader, localFileName);
        }
    }
}
