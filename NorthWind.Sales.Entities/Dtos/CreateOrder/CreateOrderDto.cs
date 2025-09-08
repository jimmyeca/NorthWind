namespace NorthWind.Sales.Entities.Dtos.CreateOrder;

#region Primary Contructors c#12
internal class CreateOrderDto(string customerId, string shipAddress, string shipCity,
    string shipCountry, string shipPostalCode, IEnumerable<CreateOrderDetailDto> orderDetails)
{
    public string CustomerId => customerId;
    public string ShipAddress => shipAddress;
    public string ShipCity => shipCity;
    public string ShipCountry => shipCountry;
    public string ShipPostalCode => shipPostalCode;
    public IEnumerable<CreateOrderDetailDto> OrderDetails => orderDetails;
}


#endregion


#region c# 2.0

//public class CreateOrderDto
//{
//    private string _customerId;
//    private string _shipAddress;
//    private string _shipCity;
//    private string _shipCountry;
//    private string _shipPostalCode;
//    private IEnumerable<CreateOrderDetailDto> _ordersDetails;

//    public CreateOrderDto(string customerId, string shipAddress, string shipCity, 
//        string shipCountry, string shipPostalCode, IEnumerable<CreateOrderDetailDto> ordersDetails)
//    {
//        _customerId = customerId;
//        _shipAddress = shipAddress;
//        _shipCity = shipCity;
//        _shipCountry = shipCountry;
//        _shipPostalCode = shipPostalCode;
//        _ordersDetails = ordersDetails;
//    }

//    public string CustomerId { get { return _customerId; } }
//    public string ShipAddress { get { return _shipAddress; } }
//    public string ShipCity { get { return _shipCity; } }
//    public string ShipCountry { get { return _shipCountry; } }
//    public string ShipPostalCode { get { return _shipPostalCode; } }
//    public IEnumerable<CreateOrderDetailDto> createOrderDetails { get { return _ordersDetails; } }

//}

#endregion


#region Propiedades automaticas c# 3.0

//public class CreateOrderDto
//{
//    public string CustomerId { get; private set; }
//    public string ShipAddress { get; private set; }
//    public string ShipCity { get; private set; }
//    public string ShipCountry { get; private set; }
//    public string ShipPostalCode { get; private set; }
//    public IEnumerable<CreateOrderDetailDto> OrderDetails { get; private set; }

//    public CreateOrderDto(string customerId, string shipAddress, string shipCity, 
//        string shipCountry, string shipPostalCode, IEnumerable<CreateOrderDetailDto> orderDetails)
//    {
//        CustomerId = customerId;
//        ShipAddress = shipAddress;
//        ShipCity = shipCity;
//        ShipCountry = shipCountry;
//        ShipPostalCode = shipPostalCode;
//        OrderDetails = orderDetails;
//    }
//}
#endregion