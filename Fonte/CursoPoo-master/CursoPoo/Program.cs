

var pessoa = new Pessoa();
pessoa.Nome = "Luis";
pessoa.Profissao = "Programador";
pessoa.Telefone = "1231231232";

var pessoa2 = new Pessoa("Luis", "Programador", "123123132");
pessoa2.Nome = "Qualquer Nome";

//var pessoa = new Pessoa
//{
//    Nome = "Luis",
//    Profissao = "Programador",
//    Telefone = "1231231232"
//};

pessoa.Apresentar();
pessoa.Apresentar("Fulano");

var funcionario = new Funcionario("Luis Funcionario", "Programador", "1231231232", 15000);

// Console.WriteLine($"{funcionario.Nome}, {funcionario.Profissao}, {funcionario.Telefone}");

funcionario.Apresentar();

Pessoa[] pessoas = { pessoa, funcionario };

foreach (var p in pessoas)
{
    p.Apresentar();
}

//public abstract class Pessoa
public class Pessoa
{
    public Pessoa() { }
    public Pessoa(string nome, string profissao, string telefone)
    {
        Nome = nome;
        Profissao = profissao;
        Telefone = telefone;
    }

    public string Nome { get; set; }
    public string Profissao { get; set; }
    public string Telefone { get; set; }

    public virtual void Apresentar()
    {
        Console.WriteLine(FormatarMensagem());
    }

    // Overload
    public void Apresentar(string nome)
    {
        Console.WriteLine($"Olá, {nome}: {FormatarMensagem()}");
    }

    private string FormatarMensagem()
    {
        return $"{Nome}, {Profissao}, {Telefone}";
    }

    // public abstract void Comprar();
}

public class Funcionario : Pessoa
{
    public Funcionario(string nome, string profissao, string telefone, int salario) : base(nome, profissao, telefone)
    {
        Salario = salario;
    }

    public int Salario { get; set; }

    public override void Apresentar()
    {
        base.Apresentar();
        Console.WriteLine($"Salario: {Salario}");
    }

    //public override void Comprar()
    //{
    //    throw new NotImplementedException();
    //}
}

public interface IPessoa
{
    void Apresentar();
}

public interface IPagante
{
    void Pagar();
}

public class Cliente : IPessoa, IPagante
{
    public void Apresentar()
    {
        throw new NotImplementedException();
    }

    public void Pagar()
    {
        throw new NotImplementedException();
    }
}