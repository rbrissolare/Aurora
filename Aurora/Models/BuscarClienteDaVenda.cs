using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aurora.Models
{
    public class BuscarClienteDaVenda
    {
        
        public static Cliente BuscarClientePorVenda(int idVenda)
        {
            string conexaodb = "Server=localhost;Database=auroravendasdb;Uid=root;Pwd=admin;";

            Cliente cliente = null;

            string sql = @"SELECT c.nome, c.cpf FROM vendas v JOIN clientes c ON c.idclientes = v.idclientes
                            WHERE v.idvendas = @idvendas;";

            using (MySqlConnection conexao = new MySqlConnection(conexaodb))
            {
                try
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@idvendas", idVenda);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cliente = new Cliente
                                {
                                    Nome = reader.GetString("nome"),
                                    Cpf = reader.GetString("cpf")
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar cliente: " + ex.Message);


                }

            }

            return cliente;
        }

    }
}
