using ExercicioRevisao2;

internal class Program
{
    private static void Main(string[] args)
    {
        List<IEmpresa> empresas = new();



        Empresa varejo = new Varejo(true);
        varejo.Nome = "Varejão Supermercados";
        varejo.CNPJ = "78.357.753/0001-12";
        empresas.Add(varejo);
        

        Empresa empreiteira = new Empreiteira();
        empreiteira.Nome = "Construtora Construção";
        empreiteira.CNPJ = "55.357.753/0001-12";
        empresas.Add(empreiteira);

        foreach (IEmpresa empresa in empresas)
        {
            empresa.ImprimirInformacoesEmpresa();
            empresa.RealizarVenda();
        }



    }
}