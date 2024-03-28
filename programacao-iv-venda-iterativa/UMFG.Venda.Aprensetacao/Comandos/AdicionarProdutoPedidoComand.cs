using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UMFG.Venda.Aprensetacao.Classes;
using UMFG.Venda.Aprensetacao.ViewModels;

namespace UMFG.Venda.Aprensetacao.Comandos
{
    /// <summary>
    /// Esse método parece lidar com a adição de um produto ao pedido e a
    /// atualização do total do pedido, mas só realiza essas ações se um produto
    /// válido estiver selecionado
    /// </summary>
    /// 
    internal sealed class AdicionarProdutoPedidoComand : AbstractCommand
    {
        // MODIFICACAO
        // Execute = chamado quando o comando é executado
        public override void Execute(object? parameter)
        {
            // Parameter é convertido para o tipo "ListarProdutosViewModel" usando a expressão "as"
            var vm = parameter as ListarProdutosViewModel;

            // Se for validado o pedido não é gerado
            if (vm == null || string.IsNullOrWhiteSpace(vm.ProdutoSelecionado.Descricao))
            {
                MessageBox.Show("Nenhum pedido foi selecionado");
                return;
            }

            vm.Pedido.Produtos.Add(vm.ProdutoSelecionado); // Adiciona o produto ao pedido
            vm.Pedido.Total = vm.Pedido.Produtos.Sum(x => x.Preco); // Atuaiza o preço total do pedido
            vm.OnPedidoChanged(); // Avisa que o Pedido foi alterado

        }

    }
}
