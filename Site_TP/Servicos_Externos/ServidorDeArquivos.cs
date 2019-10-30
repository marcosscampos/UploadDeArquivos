using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Site_TP.Servicos_Externos {
    public class ServidorDeArquivos {

        public void UploadDeArquivo(Stream reader, string nomeDoArquivo) {

            #region conexão
            string con = @"DefaultEndpointsProtocol=https;AccountName=aulasvinicius;AccountKey=CrC6Bv5HtJEPHOp+Wr5u4HTHfd+vWSjUK0qkXlLUS3abX05aBq2DXyI+lnu5rrlys5LC9mA9x8TszeHLSYs6Dg==;EndpointSuffix=core.windows.net";
            CloudStorageAccount cloudStorageAccount = null;
            CloudStorageAccount.TryParse(con, out cloudStorageAccount);
            #endregion

            //pegando a referência do container na azure
            var cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();
            var container = cloudBlobClient.GetContainerReference("api-fotos");

            #region upload de arquivos
            //cria um container se não existir
            container.CreateIfNotExists();

            //Fazer o upload da foto
            CloudBlockBlob cloudBlockBlob = container.GetBlockBlobReference(nomeDoArquivo);
            cloudBlockBlob.UploadFromStream(reader);

            #endregion
        }
        public void UploadDeArquivo(FileStream reader, string nomeDoArquivo) {

            #region conexão
            string con = @"DefaultEndpointsProtocol=https;AccountName=aulasvinicius;AccountKey=CrC6Bv5HtJEPHOp+Wr5u4HTHfd+vWSjUK0qkXlLUS3abX05aBq2DXyI+lnu5rrlys5LC9mA9x8TszeHLSYs6Dg==;EndpointSuffix=core.windows.net";
            CloudStorageAccount cloudStorageAccount = null;
            CloudStorageAccount.TryParse(con, out cloudStorageAccount);
            #endregion

            //pegando a referência do container na azure
            var cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();
            var container = cloudBlobClient.GetContainerReference("api-fotos");

            #region upload de arquivos
            //cria um container se não existir
            container.CreateIfNotExists();

            //Fazer o upload da foto
            CloudBlockBlob cloudBlockBlob = container.GetBlockBlobReference(nomeDoArquivo);
            cloudBlockBlob.UploadFromStream(reader);

            #endregion
        }
    }
}