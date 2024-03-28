using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UMFG.Venda.Aprensetacao.Interfaces;
using UMFG.Venda.Aprensetacao.Models;
using UMFG.Venda.Aprensetacao.ViewModels;

namespace UMFG.Venda.Aprensetacao.UserControls
{
    /// <summary>
    /// Interação lógica para ucReceber.xam
    /// </summary>
    public partial class ucReceber : UserControl
    {
        private ucReceber(IObserver observer, PedidoModel pedido)
        {
            InitializeComponent();
            DataContext = new ReceberViewModel(this, observer, pedido);
        }

        internal static PedidoModel Exibir(IObserver observer,
            PedidoModel pedido)
        {
            var tela = new ucReceber(observer, pedido);
            var vm = tela.DataContext as ReceberViewModel;

            vm.Notify();
            return vm.Pedido;
        }

        private void Finalizar(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NumeroCartao.Text) || string.IsNullOrWhiteSpace(CartaoCVV.Text) ||
                string.IsNullOrWhiteSpace(ValidadeDoCartao.Text) || string.IsNullOrWhiteSpace(NomeCartao.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos, para validar o pagamento.", "Erro de validação", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            MessageBox.Show("Pagamento realizado com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void VoltarParaLista(object sender, RoutedEventArgs e)
        {
            var frame = Window.GetWindow(this).Content as Frame;
            if (frame != null && frame.CanGoBack)
            {
                frame.GoBack();
            }
        }
    }
}
