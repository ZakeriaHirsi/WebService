using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using WebService.Business;

namespace WebService
{
    #region : MyService :
    public class MyService : IMyService
    {
        #region Class Variables
        private List<CustomerEntity> __Customers;
        #endregion

        #region Constructor
        public MyService()
        {
            CustomerEntity __Customer1 = new CustomerEntity();
            __Customer1.ID = 1;
            __Customer1.Forename = "Zakeria";
            __Customer1.Surname = "Hirsi";
            __Customer1.Address = "101 Aston Freeway";

            CustomerEntity __Customer2 = new CustomerEntity();
            __Customer2.ID = 2;
            __Customer2.Forename = "Bjorn";
            __Customer2.Surname = "Buckingham";
            __Customer2.Address = "Northampton";

            CustomerEntity __Customer3 = new CustomerEntity();
            __Customer3.ID = 3;
            __Customer3.Forename = "Ethan";
            __Customer3.Surname = "Venencia";
            __Customer3.Address = "Dudley";

            CustomerEntity __Customer4 = new CustomerEntity();
            __Customer4.ID = 4;
            __Customer4.Forename = "Andrew";
            __Customer4.Surname = "Dobson";
            __Customer4.Address = "Coventry";

            __Customers = new List<CustomerEntity>
            {
                __Customer1,
                __Customer2,
                __Customer3,
                __Customer4
            };
        }
        #endregion

        #region GetCustomer
        public CustomerEntity GetCustomer(CustomerRequest request)
        {
            try
            {
                return __Customers.Single(customer => customer.ID == request.ID);
            }
            catch (InvalidOperationException ex)
            {
                ExceptionHandler _ExceptionHandler = new ExceptionHandler();
                _ExceptionHandler.Issue = "Invalid ID inputted";
                _ExceptionHandler.Details = ex.Message;

                throw new FaultException<ExceptionHandler>(_ExceptionHandler);
            }

        }
        #endregion

        #region GetForename
        public string GetForename(int id)
        {
            try
            {
                return __Customers.Single(customer => customer.ID == id).Forename;
            }
            catch(InvalidOperationException ex)
            {
                ExceptionHandler _ExceptionHandler = new ExceptionHandler();
                _ExceptionHandler.Issue = "Invalid ID inputted";
                _ExceptionHandler.Details = ex.Message;

                throw new FaultException<ExceptionHandler>(_ExceptionHandler);
            }
        }
        #endregion

    } 
    #endregion
}
