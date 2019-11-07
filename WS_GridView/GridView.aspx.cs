using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GridView : System.Web.UI.Page
{

    string descricao = "CX";
    string qtdunico = "10";
    string embalagemSelecionada;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            gvGridView1();
        }
        
    }
       
    

    public List<lista> listaCompletatotal()
    {
        lista l;
        List<lista> listaCompleta = new List<lista>();
        
        l = new lista();
        l.codigo = 111;
        l.embalagem = "UN";
        l.qtd = 1;
        listaCompleta.Add(l);

        l = new lista();
        l.codigo = 112;
        l.embalagem = "CX";
        l.qtd = 1;
        listaCompleta.Add(l);

        l = new lista();
        l.codigo = 113;
        l.embalagem = "PT";
        l.qtd = 1;
        listaCompleta.Add(l);



        return listaCompleta;
    }

  
    public void gvGridView1() {
        List<lista> LsGridView = new List<lista>();

        LsGridView = listaCompletatotal();
        
        GridView1.DataSource = LsGridView;
        GridView1.DataBind();
    }



    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList ddl = (DropDownList)sender;
        string idGrid = ddl.UniqueID.Substring(10, 5);

        foreach (GridViewRow row in GridView1.Rows)
        {

            if (row.UniqueID.Contains(idGrid))
            {
                if (ddl.SelectedValue == descricao) {
                    GridView1.Rows[row.RowIndex].Cells[2].Text = qtdunico;
                }
                else
                {
                    GridView1.Rows[row.RowIndex].Cells[2].Text = "1";
                }

                
            }

        }

    }
}