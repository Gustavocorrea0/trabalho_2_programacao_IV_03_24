using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UMFG.Venda.Aprensetacao.Classes;
using UMFG.Venda.Aprensetacao.Interfaces;
using UMFG.Venda.Aprensetacao.Models;

namespace UMFG.Venda.Aprensetacao.ViewModels
{
    internal sealed class ReceberViewModel : AbstractViewModel
    {
        // Dados Cartão
        private string _nomeCartao;
        private string _cartaoCVV;
        private string _numeroCartao;
        private string _validadeCartao;
        private PedidoModel _pedido = new PedidoModel();

        // Validadação de Nome do Cartão
        private string NomeCartao
        {

            get => _nomeCartao;

            set
            {
                if (_nomeCartao != value)
                {
                    _nomeCartao = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(PagamentoValidado));
                }
            }
        }

        // Validadação do codigo CVV
        private string CartaoCVV
        {
            get => _cartaoCVV;

            set
            {
                _cartaoCVV = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(PagamentoValidado));
            }

        }

        // Validadacao do numero do cartão
        private string NumeroCartao
        {

            get => _numeroCartao;

            set
            {
                _numeroCartao = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(PagamentoValidado));
            }

        }

        // Validação da validade do cartão
        private string ValidadeCartao
        {

            get => _validadeCartao;

            set
            {
                _validadeCartao = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(PagamentoValidado));
            }

        }

        public bool PagamentoValidado
        {
            get
            {
                return
                    !string.IsNullOrWhiteSpace(NomeCartao) && !string.IsNullOrWhiteSpace(NumeroCartao)
                    && NumeroCartao.Length == 16 && DateTime.TryParseExact(ValidadeCartao,
                    "MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var expiryDate)
                    && expiryDate > DateTime.Now && CartaoCVV.Length == 3;
            }
        }

        public PedidoModel Pedido
        {
            get => _pedido;
            set => SetField(ref _pedido, value);
        }

        // Notifica as alterações
        public ReceberViewModel(UserControl userControl,
            IObserver observer, PedidoModel pedido) : base("Receber")
        {
            UserControl = userControl ?? throw new ArgumentNullException(nameof(userControl));
            MainUserControl = observer ?? throw new ArgumentNullException(nameof(observer));
            Pedido = pedido ?? throw new ArgumentNullException(nameof(pedido));

            Add(observer);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
