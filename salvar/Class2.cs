using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace salvar
{
    class Class2
    {
        public static string caminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Ivanilson_Santos\03_CSharp\Projetos\Clinica\BDClinica.mdb'";

        public static void cadastrar(Class1 classe1)
        {
            OleDbConnection acesso = new OleDbConnection();
            acesso.ConnectionString = Class2.caminho;
            OleDbParameter campo1 = new OleDbParameter("@vcodigo", classe1.CODIGO);
            OleDbParameter campo2 = new OleDbParameter("@vnome", classe1.NOME);
            OleDbParameter campo3 = new OleDbParameter("@vidade", classe1.IDADE);
            OleDbCommand comando = new OleDbCommand();
            comando.Connection = acesso;
            comando.Parameters.Add(campo1);
            comando.Parameters.Add(campo2);
            comando.Parameters.Add(campo3);
            comando.CommandText = "insert into pacientes (codigo,nome,idade) values (@vcodigo,@vnome,@vidade)";
            acesso.Open();
            comando.ExecuteNonQuery();
            acesso.Close();
        }
    }
}
