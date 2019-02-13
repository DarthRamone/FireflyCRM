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
      //{"Передача в кредит", PaymentMethod.CREDIT},
      {"Предоплата", PaymentMethod.PREPAYMENT},
      //{"Полный расчёт", PaymentMethod.FULL_PAYMENT},
      //{"Аванс", PaymentMethod.ADVANCE},
      //{"Оплата кредита", PaymentMethod.CREDIT_PAYMENT},
      //{"Частичный расчет и кредит", PaymentMethod.PARTIAL_PAYMENT},
    };
    
    //TODO: Fill rest of objects
    private readonly Dictionary<string, PaymentObject> _paymentObjectsMap = new Dictionary<string, PaymentObject>
    {
      {"Услуга", PaymentObject.SERVICE},
    };
    
    private readonly Dictionary<string, VAT> _vatMap = new Dictionary<string, VAT>
    {
      {"Без НДС", VAT.NONE},
    };
    
    private readonly Dictionary<string, TaxSystem> _taxMap = new Dictionary<string, TaxSystem>
    {
      {"УСН Доход", TaxSystem.USN_INCOME},
    };
    
    public ReceiptItemViewModel ReceiptItemViewModel { get; set; }

    
    #region payment methods

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

    #endregion


    #region payment objects

    private IList<string> _paymentObjects;
    public IList<string> PaymentObjects
    {
      get => _paymentObjects;
      set => SetProperty(ref _paymentObjects, value);
    }

    private string _selectedPaymentObject;

    public string SelectedPaymentObject
    {
      get => _selectedPaymentObject;
      set
      {
        SetProperty(ref _selectedPaymentObject, value);
        ReceiptItemViewModel.PaymentObject = _paymentObjectsMap[value];
      }
    }

    #endregion


    #region VAT

    private IList<string> _vat;
    public IList<string> Vats
    {
      get => _vat;
      set => SetProperty(ref _vat, value);
    }

    private string _selectedVat;

    public string SelectedVat
    {
      get => _selectedVat;
      set
      {
        SetProperty(ref _selectedVat, value);
        ReceiptItemViewModel.Vat = _vatMap[value];
      }
    }

    #endregion


    #region Tax

    private IList<string> _taxes;
    public IList<string> Taxes
    {
      get => _taxes;
      set => SetProperty(ref _taxes, value);
    }

    private string _selectedTax;

    public string SelectedTax
    {
      get => _selectedTax;
      set
      {
        SetProperty(ref _selectedTax, value);
        ReceiptItemViewModel.Sno = _taxMap[value];
      }
    }

    #endregion

    public ReceiptItemPageViewModel()
    {
      PaymentMethods = _paymentMethodsMap.Keys.ToList();
      PaymentObjects = _paymentObjectsMap.Keys.ToList();
      Vats = _vatMap.Keys.ToList();
      Taxes = _taxMap.Keys.ToList();
    }
  }
}