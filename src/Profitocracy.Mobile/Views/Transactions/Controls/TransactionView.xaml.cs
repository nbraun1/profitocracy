using Profitocracy.Mobile.Models.Transactions;

namespace Profitocracy.Mobile.Views.Transactions.Controls;

public partial class TransactionView : ContentView
{
    public TransactionView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty TransactionProperty = BindableProperty.Create(
        nameof(Transaction),
        typeof(TransactionModel),
        typeof(TransactionView));
    
    public static readonly BindableProperty IsMultiSelectionProperty = BindableProperty.Create(
        nameof(IsMultiSelection),
        typeof(bool),
        typeof(bool),
        false);

    public TransactionModel Transaction
    {
        get => (TransactionModel)GetValue(TransactionProperty);
        set
        {
            SetValue(TransactionProperty, value);
            BindingContext = Transaction;
        }
    }
    
    public bool IsMultiSelection
    {
        get => (bool)GetValue(IsMultiSelectionProperty);
        set => SetValue(IsMultiSelectionProperty, value);
    }
}
