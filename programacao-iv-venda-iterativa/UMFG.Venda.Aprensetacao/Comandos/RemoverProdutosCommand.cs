using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMFG.Venda.Aprensetacao.Classes;
using UMFG.Venda.Aprensetacao.ViewModels;

namespace UMFG.Venda.Aprensetacao.Comandos
{
    /// <summary>
    /// Verifica se um produto está selecionado e na lista de produtos do pedido antes de removê-lo.
    /// e atualiza o total do pedido
    /// </summary>
    internal sealed class RemoverProdutosCommand : AbstractCommand
    {
        // Valida se produto esta na lista do pedido
        public override bool CanExecute(object? parameter)
        {
            var vm = parameter as ListarProdutosViewModel; // Tenta fazer um cast do parâmetro para o tipo
            return vm?.ProdutoSelecionado != null && vm.Pedido.Produtos.Contains(vm.ProdutoSelecionado); // Verifica se vm não é nulo
        }


        public override void Execute(object? parameter)
        {
            var vm = parameter as ListarProdutosViewModel; // Tenta fazer um cast do parâmetro para o tipo

            if (vm != null && vm.ProdutoSelecionado != null)
            {
                vm.Pedido.Produtos.Remove(vm.ProdutoSelecionado); // Retira um Produto
                vm.Pedido.Total = vm.Pedido.Produtos.Sum(a => a.Preco); // Atualiza o valor do pedido
                vm.OnPedidoChanged(); // Cofirma alteração do pedido
            }
        }
    }

}
