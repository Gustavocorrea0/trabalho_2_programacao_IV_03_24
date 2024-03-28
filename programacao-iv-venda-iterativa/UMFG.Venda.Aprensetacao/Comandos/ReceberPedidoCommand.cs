using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UMFG.Venda.Aprensetacao.Classes;
using UMFG.Venda.Aprensetacao.UserControls;
using UMFG.Venda.Aprensetacao.ViewModels;

namespace UMFG.Venda.Aprensetacao.Comandos
{
    /// <summary>
    /// Verifica se um produto foi selecionado antes de receber o pedido,
    /// exibindo uma mensagem de erro se nenhum produto for selecionado.
    /// </summary>

    internal sealed class ReceberPedidoCommand : AbstractCommand
    {
        public override void Execute(object? parameter)
        {

            try
            {
                var vm = parameter as ListarProdutosViewModel;

                // Valida se pedido foi seleciona ou não
                if (string.IsNullOrWhiteSpace(vm.ProdutoSelecionado.Referencia))
                {
                    MessageBox.Show("Selecione um produto para fechar o pedido");
                    return;
                }

                vm.Pedido = ucReceber.Exibir(vm.MainUserControl, vm.Pedido);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
