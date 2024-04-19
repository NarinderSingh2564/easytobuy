﻿using EasyToBuy.Data.DBClasses;
using EasyToBuy.Models.CommonModel;
using EasyToBuy.Models.InputModels;
using EasyToBuy.Models.Models;
using EasyToBuy.Repository.Abstract;
using EasyToBuy.Services.Interactions;
using System.Reflection;

namespace EasyToBuy.Repository.Concrete
{
    public class AccountRepository:IAccountRepository
    {
        public async Task<ApiResponseModel> CheckUser(string mobile, string password)
        {
            using (AccountService accountService = new AccountService())
            {
                return await accountService.CheckUser(mobile, password);
            }
        }

        public async Task<ApiResponseModel> GetAddressListByUserId(int userID)
        {
            using (AccountService accountService = new AccountService())
            {
                return await accountService.GetAddressListByUserId(userID);
            }
        }
        public async Task<IEnumerable<CountryModel>> GetCountryList()
        {
            using (AccountService accountService = new AccountService())
            {
                return await accountService.GetCountryList();
            }
        }
        public async Task<ApiResponseModel> CountryAddEdit(CountryInputModel countryInputModel)
        {
            using (AccountService accountService = new AccountService())
            {
                return await accountService.CountryAddEdit(countryInputModel);
            }
        }
        public async Task<ApiResponseModel> CountryDelete(int Id)
        {
            using (AccountService accountService = new AccountService())
            {
                return await accountService.CountryDelete(Id);
            }
        }
        public async Task<IEnumerable<StateModel>> GetStatesList()
        {
            using (AccountService accountService = new AccountService())
            {
                return await accountService.GetStatesList();
            }
        }
        public async Task<ApiResponseModel> StateAddEdit(StateInputModel stateInputModel)
        {
            using (AccountService accountService = new AccountService())
            {
                return await accountService.StateAddEdit(stateInputModel);
            }
        }
        public async Task<ApiResponseModel> StateDelete(int Id)
        {
            using (AccountService accountService = new AccountService())
            {
                return await accountService.StateDelete(Id);
            }
        }
    }
}
