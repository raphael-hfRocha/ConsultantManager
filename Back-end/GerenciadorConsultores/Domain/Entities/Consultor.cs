using System;

namespace Domain.Entities;
public class Consultor
{
    private Int32 _id;
    private String _nome;
    private String _email;
    private String _telefone;
    private String _areaEspecialidade;
    private DateTime _dataCadastro;

    public Int32 Id { get => getId(); set => setId(value); }
    public String Nome { get => getNome(); set => setNome(value); }
    public String Email { get => getEmail(); set => setEmail(value); }
    public String Telefone { get => getTelefone(); set => setTelefone(value); }
    public String AreaEspecialidade { get => getAreaEspecialidade(); set => setAreaEspecialidade(value); }
    public DateTime DataCadastro { get => getDataCadastro(); set => setDataCadastro(value); }

    public Consultor(Int32 id, String nome, String email, String telefone, String areaEspecialidade, DateTime dataCadastro)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Telefone = telefone;
        AreaEspecialidade = areaEspecialidade;
        DataCadastro = dataCadastro;
    }

    private Int32 getId()
    {
        return _id;
    }
    private void setId(Int32 value)
    {
        _id = value;
    }
    private String getNome()
    {
        return _nome;
    }
    private void setNome(String value)
    {
        _nome = value;
    }
    private String getEmail()
    {
        return _email;
    }
    private void setEmail(String value)
    {
        _email = value;
    }
    private String getTelefone()
    {
        return _telefone;
    }
    private void setTelefone(String value)
    {
        _telefone = value;
    }
    private String getAreaEspecialidade()
    {
        return _areaEspecialidade;
    }
    private void setAreaEspecialidade(String value)
    {
        _areaEspecialidade = value;
    }
    private DateTime getDataCadastro()
    {
        return _dataCadastro;
    }
    private void setDataCadastro(DateTime value)
    {
        _dataCadastro = value;
    }
}
