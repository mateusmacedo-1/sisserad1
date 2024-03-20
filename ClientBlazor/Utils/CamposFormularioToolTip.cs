namespace ClientBlazor.Utils
{
public static class CamposFormularioToolTip
{
    public static string TipoCliente { get; private set; } = "Selecione o tipo de cliente (Pessoa Física ou Jurídica).";
    public static string PessoaJuridica { get; private set; } = "Selecione essa opção se deseja contratar serviços em nome de uma Empresa.";
    public static string PessoaFisica { get; private set; } = "Selecione essa opção se deseja contratar serviços em nome de uma Pessoa.";
    public static string RazaoSocial { get; private set; } = "A Razão Social de uma empresa é o seu nome jurídico e é utilizada nos contratos e documentos oficiais do negócio";
    public static string CNPJ { get; private set; } = "O Cadastro Nacional de Pessoas Jurídicas (CNPJ) é o número designado pela Receita Federal na abertura da empresa. Ele serve para identificar o negócio nos mais diversos tipos de atividades, como a emissão de notas fiscais ou o pagamento dos impostos.";
    public static string NomeRepresentante { get; private set; } = "Nome da Pessoa de fará negócios em nome do Cliente.";
    public static string Email { get; private set; } = "Insira o endereço de e-mail do cliente.";
    public static string Telefone { get; private set; } = "Insira o número de telefone do cliente.";
}
}