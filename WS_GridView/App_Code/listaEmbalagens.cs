using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de listaEmbalagens
/// </summary>
public class listaEmbalagens
{

    public int codigo { get; set; }
    public string descricao { get; set; }


    public listaEmbalagens()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //

        


    }

    public List<listaEmbalagens> listarEmbalagens()
    {
        listaEmbalagens le;
        List<listaEmbalagens> lista = new List<listaEmbalagens>();

        le = new listaEmbalagens();
        le.codigo = 1;
        le.descricao = "UN";
        lista.Add(le);

        le = new listaEmbalagens();
        le.codigo = 2;
        le.descricao = "CX";
        lista.Add(le);

        le = new listaEmbalagens();
        le.codigo = 3;
        le.descricao = "PT";
        lista.Add(le);

        return lista;



    }
}