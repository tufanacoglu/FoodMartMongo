﻿using FoodMartMongo.Dtos.CustomerDtos;

namespace FoodMartMongo.Services.CustomerServices
{
    public interface ICustomerService
    {
        Task<ResultCustomerDto> GetAllCustomerAsync();
        Task CreateCustomerAsync(CreateCustomerDto createCustomerDto);
        Task UpdateCustomerAsync(UpdateCustomerDto updateCustomerDto);
        Task DeleteCustomerAsync(string customerId);
        Task<GetCustomerByIdDto> GetCustomerByIdAsync(string customerId);
    }
}
