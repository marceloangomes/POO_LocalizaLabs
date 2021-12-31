using System.IO;
namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho){
            var retornoCaminho=Directory.GetDirectories(caminho,"*",SearchOption.AllDirectories);
            foreach(var retorno in retornoCaminho ){
                System.Console.WriteLine(retorno);
            }
        }
        public void ListarArquivos(string caminho){
            var retornoArquivo=Directory.GetFiles(caminho,"*.txt",SearchOption.AllDirectories);
            foreach(var retorno in retornoArquivo ){
                System.Console.WriteLine(retorno);
            }
        }

        public void CriarDiretorio(string caminho){
            var retorno = Directory.CreateDirectory(Path.Combine(caminho,"NovoDiretorio1"));
            System.Console.WriteLine(retorno.FullName);

        }
        public void ApagarDiretorio(string caminho){
            Directory.Delete(Path.Combine(caminho,"NovoDiretorio1"),true);
        }

        public void CriarArquivoTexto(string caminho, string conteudo){
            if(!File.Exists(Path.Combine(caminho,"NovoDiretorio")))
                File.WriteAllText(caminho, conteudo);
        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo){
            using(var stream = File.CreateText(Path.Combine(caminho))){
                foreach(var linha in conteudo){
                    stream.WriteLine(linha);
                }
            }
        }

        public void AdicionarTexto(string caminho, string conteudo){
            File.AppendAllText(caminho,conteudo);
        }

        public void AdicionarArquivoTextoStream(string caminho, List<string> conteudo){
            using(var stream = File.AppendText(Path.Combine(caminho))){
                foreach(var linha in conteudo){
                    stream.WriteLine(linha);
                }
            }
        }

    }
}