using System.Collections.Generic;
using System.Linq;
using ModulBank.Models;

namespace FireflyCRM.ViewModels
{
  public class ReceiptItemPageViewModel : BasePopoverViewModel
  {
    //TODO: Refactoring: figure out how to refactor w/o dictionaries 
    private readonly Dictionary<string, PaymentMethod> _paymentMethodsMap = new Dictionary<string, PaymentMethod>
    {
      {"Предоплата 100%", PaymentMethod.FULL_PREPAYMENT},
      {"Передача в кредит", PaymentMethod.CREDIT},
      {"Предоплата", PaymentMethod.PREPAYMENT},
      {"Полный расчёт", PaymentMethod.FULL_PAYMENT},
      {"Аванс", PaymentMethod.ADVANCE},
      {"Оплата кредита", PaymentMethod.CREDIT_PAYMENT},
      {"Частичный расчет и кредит", PaymentMethod.PARTIAL_PAYMENT},
    };
    
    //TODO: Fill rest of objects
    private readonly Dictionary<string, PaymentObject> _paymentObjectsMap = new Dictionary<string, PaymentObject>
    {
      {"Услуга", PaymentObject.SERVICE},
    };
    
    public ReceiptItemViewModel ReceiptItemViewModel { get; set; }

    private IList<string> _paymentMethods;
    public IList<string> PaymentMethods
    {
      get => _paymentMethods;
      set => SetProperty(ref _paymentMethods, value);
    }

    private string _selectedPaymentMethod;

    public string SelectedPaymentMethod
    {
      get => _selectedPaymentMethod;
      set
      {
        SetProperty(ref _selectedPaymentMethod, value);
        ReceiptItemViewModel.PaymentMethod = _paymentMethodsMap[value];
      }
    }


    private IList<string> _paymentObjects;
    public IList<string> PaymentObjects
    {
      get => _paymentObjects;
      set => SetProperty(ref _paymentObjects, value);
    }
 

    public ReceiptItemPageViewModel()
    {
      PaymentMethods = _paymentMethodsMap.Keys.ToList();
      PaymentObjects = _paymentObjectsMap.Keys.ToList();
    }
  }
}